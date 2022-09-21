using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1MVC_V4.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: true),
                    BookAuthor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NumberOfBooksInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFName = table.Column<string>(maxLength: 25, nullable: false),
                    CustomerLName = table.Column<string>(maxLength: 25, nullable: false),
                    CustomerEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    LoanedBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.LoanedBookId);
                    table.ForeignKey(
                        name: "FK_Loan_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loan_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookAuthor", "BookName", "Description", "NumberOfBooksInStock" },
                values: new object[,]
                {
                    { 1, "Jamir Ondricka", "RAM reboot Refined Rubber Bacon", "Quasi ut in et. Amet sunt aut laborum dolorum eum eos. Sit minima ipsam rem perferendis vel veritatis. Sint est maxime sunt voluptas.", 3 },
                    { 9, "David Bergstrom", "B2C online Fresh", "Dolores consequatur aspernatur a velit incidunt. Ipsam aliquam ratione. Autem harum ea mollitia quia dolorem fugiat aut. Rerum qui laboriosam placeat ea molestiae ab qui quam.", 3 },
                    { 8, "Jazlyn Boyle", "Tools, Health & Sports application", "Ipsum dicta cumque porro molestias porro magnam sequi. Veniam illo quod quasi aliquam. Qui est eius excepturi sit tempora.", 3 },
                    { 7, "Shayne Feil", "back-end GB Iceland Krona", "Tenetur quia saepe rerum quis commodi qui dolorem non. Iste doloribus omnis rerum rerum facilis vel reiciendis amet expedita. Id vel error velit.", 3 },
                    { 6, "Keenan Parker", "back-end compressing plum", "Accusamus voluptatibus illum. Voluptas possimus dolores iusto quidem dolores perferendis quia excepturi consequatur. Ipsam adipisci ut omnis ea dicta ipsam. Voluptatem illo nobis aut voluptatem blanditiis qui voluptas rerum iusto.", 3 },
                    { 10, "Elmer Muller", "Networked copy Division", "Sit aut est deserunt et neque. Sed molestias quasi. Et et perspiciatis soluta. Ut omnis corrupti dolor excepturi saepe. Et magnam voluptatem voluptatem laudantium. Sit perspiciatis mollitia saepe.", 3 },
                    { 4, "Tiffany Johnston", "Jamaica green", "Facilis soluta reprehenderit est. Assumenda et qui id dicta quo omnis incidunt officiis. Tempore dolorem debitis possimus et. Quia nemo debitis. Eos dolore quo libero fugiat velit quo.", 3 },
                    { 3, "Madilyn Cartwright", "haptic", "Qui nam fugit commodi sint. Fugit sunt quis. Porro enim in. Aut voluptas aut odio qui dolores reprehenderit. Perferendis quisquam possimus eum velit error nisi dolores. Ipsa qui cupiditate repellendus atque exercitationem necessitatibus magni occaecati.", 3 },
                    { 2, "Jaiden Lebsack", "Communications incubate homogeneous", "Consectetur repellendus voluptatem id. Corrupti a autem et quos. Corrupti asperiores et incidunt commodi. Voluptatem recusandae fugiat molestiae temporibus labore voluptatem velit magnam ab. Distinctio odit consequatur voluptatem assumenda ut qui.", 3 },
                    { 5, "Aiden Sipes", "Fresh Metal Borders", "Soluta doloribus ullam. Et vel omnis ut qui inventore amet. Autem sint inventore perferendis occaecati illum est. Cum consequuntur cum odit voluptatem qui voluptatem tempore tempora.", 3 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[,]
                {
                    { 9, "Helene_Hammes@yahoo.com", "Thelma", "Jaskolski" },
                    { 1, "Carmel_Turner4@yahoo.com", "Sandrine", "Kshlerin" },
                    { 2, "Ladarius.Hayes97@gmail.com", "Tamia", "Stanton" },
                    { 3, "Rafaela63@hotmail.com", "Vern", "Bernier" },
                    { 4, "Ronny.McKenzie@yahoo.com", "Ottis", "Heaney" },
                    { 5, "Zoey82@gmail.com", "Julien", "Nienow" },
                    { 6, "Christop.Koepp89@hotmail.com", "Clark", "O'Connell" },
                    { 7, "Cordia47@yahoo.com", "Major", "Paucek" },
                    { 8, "Nathanial_Sporer42@yahoo.com", "Rosalee", "Boehm" },
                    { 10, "Carmel.Runolfsson@gmail.com", "Evan", "Botsford" }
                });

            migrationBuilder.InsertData(
                table: "Loan",
                columns: new[] { "LoanedBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 4, 2, new DateTime(2022, 9, 21, 15, 58, 35, 678, DateTimeKind.Local).AddTicks(3998), new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(2259) },
                    { 4, 3, 4, new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5930) },
                    { 5, 2, 4, new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5938), new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5940) },
                    { 2, 2, 8, new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5758), new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5779) },
                    { 3, 7, 8, new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5914), new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5918) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_BookId",
                table: "Loan",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_CustomerId",
                table: "Loan",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
