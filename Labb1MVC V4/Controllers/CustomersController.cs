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
    public class CustomersController : Controller
    {
        private readonly BookDbContext _context;

        public CustomersController(BookDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }


        public async Task<IActionResult> LoanedBooks(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           

            var customer = _context.Loan.Include(l => l.Book).Include(c => c.Customer).Where(l => l.Customer.CustomerId == id);

            var customer1 = _context.Customers.Include(x => x.LoanedBook).Where(x => x.CustomerId == id);

            //if (_context.Loan.Include(l => l.Book).Include(c => c.Customer).Where(l => l.Customer.CustomerId == id).Where(x=> x.LoanedBookId == null)
            //{

            //}






            //var customer1 = _context.Loan.Where(l => l.CustomerId == id).Include(l => l.CustomerId);

            //var customer3 = _context.Loan.Include(b => b.Book.BookName).Where(l => l.CustomerId == id);

            //var customer2 = from _context. in _context.Customers
            //                 join aSchool in _context on aStudent.SchoolID equals aSchool.Id
            //select new
            //{
            //    aStudent.Id,
            //    aStudent.Name,
            //    aStudent.Surname,
            //    SchoolName = aSchool.Name
            //};


            if (customer == null)
            {
                return NotFound();
            }


            return View(await customer.ToListAsync());
        }



        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerFName,CustomerLName,CustomerEmail")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerFName,CustomerLName,CustomerEmail,CustomerEmail")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
