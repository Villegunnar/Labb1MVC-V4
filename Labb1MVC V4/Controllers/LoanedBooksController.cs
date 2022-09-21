using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labb1MVC_V4.Models;

namespace Labb1MVC_V4.Controllers
{
    public class LoanedBooksController : Controller
    {
        private readonly BookDbContext _context;

        public LoanedBooksController(BookDbContext context)
        {
            _context = context;
        }

        // GET: LoanedBooks
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Loan.Include(l => l.Book).Include(l => l.Customer);
            return View(await appDbContext.ToListAsync());
        }

        // GET: LoanedBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanedBook = await _context.Loan
                .Include(l => l.Book)
                .Include(l => l.Customer)
                .FirstOrDefaultAsync(m => m.LoanedBookId == id);
            if (loanedBook == null)
            {
                return NotFound();
            }

            return View(loanedBook);
        }

        // GET: LoanedBooks/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookName");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFName");
            return View();
        }

        // POST: LoanedBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoanedBookId,BookId,CustomerId,LoanDate")] LoanedBook loanedBook)
        {
            if (ModelState.IsValid)
            {

                var bookstock = _context.Books.FirstOrDefault(x => x.BookId == loanedBook.BookId);

                if (bookstock.NumberOfBooksInStock == 0)
                {
                    return RedirectToAction(nameof(Create));
                }
                bookstock.NumberOfBooksInStock--;

              


                _context.Add(loanedBook);
                await _context.SaveChangesAsync();
              
              
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookName", loanedBook.BookId);

            

                      ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFName", loanedBook.CustomerId);
            return View(loanedBook);
        }

        // GET: LoanedBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanedBook = await _context.Loan.FindAsync(id);
            if (loanedBook == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", loanedBook.BookId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFName", loanedBook.CustomerId);
            return View(loanedBook);
        }

        // POST: LoanedBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoanedBookId,BookId,CustomerId,LoanDate")] LoanedBook loanedBook)
        {
            if (id != loanedBook.LoanedBookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanedBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanedBookExists(loanedBook.LoanedBookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", loanedBook.BookId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFName", loanedBook.CustomerId);
            return View(loanedBook);
        }

        // GET: LoanedBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanedBook = await _context.Loan
                .Include(l => l.Book)
                .Include(l => l.Customer)
                .FirstOrDefaultAsync(m => m.LoanedBookId == id);
            if (loanedBook == null)
            {
                return NotFound();
            }

            return View(loanedBook);
        }

        public async Task<IActionResult> Return(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanedBook = await _context.Loan
                .Include(l => l.Book)
                .Include(l => l.Customer)
                .FirstOrDefaultAsync(m => m.LoanedBookId == id);
            if (loanedBook == null)
            {
                return NotFound();
            }

            return View(loanedBook);
        }
        [HttpPost, ActionName("Return")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReturnConfirmed(int id)
        {
            var loanedBook = await _context.Loan.FindAsync(id);
            _context.Loan.Remove(loanedBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: LoanedBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loanedBook = await _context.Loan.FindAsync(id);
            _context.Loan.Remove(loanedBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanedBookExists(int id)
        {
            return _context.Loan.Any(e => e.LoanedBookId == id);
        }
    }
}
