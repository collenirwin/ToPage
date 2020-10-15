using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Age = table.Column<int>(nullable: false),
                    FavoriteColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 1, 40, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 342, 85, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 341, 46, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 340, 36, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 339, 86, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 338, 65, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 337, 11, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 336, 94, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 335, 104, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 334, 93, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 333, 13, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 332, 60, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 331, 57, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 330, 116, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 329, 78, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 328, 31, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 327, 30, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 326, 56, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 325, 28, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 324, 37, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 323, 85, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 322, 103, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 321, 81, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 320, 77, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 319, 97, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 318, 25, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 317, 52, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 316, 26, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 343, 95, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 315, 95, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 344, 14, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 346, 95, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 373, 38, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 372, 104, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 371, 93, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 370, 85, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 369, 67, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 368, 76, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 367, 29, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 366, 114, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 365, 15, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 364, 110, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 363, 82, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 362, 114, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 361, 58, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 360, 14, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 359, 24, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 358, 90, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 357, 89, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 356, 72, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 355, 2, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 354, 82, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 353, 79, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 352, 99, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 351, 26, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 350, 42, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 349, 71, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 348, 44, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 347, 89, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 345, 113, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 314, 8, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 313, 100, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 312, 3, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 279, 48, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 278, 3, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 277, 13, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 276, 41, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 275, 97, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 274, 53, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 273, 102, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 272, 27, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 271, 81, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 270, 15, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 269, 62, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 268, 62, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 267, 31, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 266, 46, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 265, 39, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 264, 67, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 263, 65, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 262, 79, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 261, 45, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 260, 34, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 259, 86, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 258, 73, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 257, 67, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 256, 55, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 255, 43, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 254, 17, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 253, 64, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 280, 18, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 281, 54, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 282, 21, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 283, 85, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 311, 74, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 310, 38, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 309, 43, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 308, 109, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 307, 10, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 306, 114, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 305, 20, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 304, 100, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 303, 98, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 302, 6, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 301, 105, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 300, 92, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 299, 59, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 374, 4, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 298, 3, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 296, 23, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 295, 91, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 294, 45, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 293, 43, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 292, 59, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 291, 12, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 290, 7, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 289, 110, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 288, 10, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 287, 7, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 286, 9, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 285, 79, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 284, 70, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 297, 90, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 252, 4, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 375, 93, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 377, 101, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 467, 114, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 466, 15, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 465, 25, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 464, 40, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 463, 10, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 462, 55, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 461, 5, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 460, 88, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 459, 84, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 458, 60, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 457, 96, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 456, 7, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 455, 44, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 454, 29, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 453, 4, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 452, 82, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 451, 40, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 450, 1, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 449, 68, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 448, 115, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 447, 18, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 446, 7, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 445, 72, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 444, 102, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 443, 104, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 442, 114, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 441, 46, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 468, 26, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 440, 20, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 469, 116, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 471, 36, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 498, 53, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 497, 55, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 496, 1, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 495, 112, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 494, 120, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 493, 91, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 492, 83, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 491, 103, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 490, 26, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 489, 57, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 488, 28, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 487, 69, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 486, 39, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 485, 110, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 484, 68, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 483, 94, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 482, 24, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 481, 66, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 480, 25, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 479, 116, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 478, 13, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 477, 50, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 476, 21, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 475, 89, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 474, 48, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 473, 48, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 472, 96, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 470, 64, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 439, 67, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 438, 94, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 437, 81, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 404, 1, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 403, 88, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 402, 17, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 401, 108, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 400, 52, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 399, 84, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 398, 11, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 397, 105, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 396, 59, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 395, 67, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 394, 112, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 393, 24, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 392, 97, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 391, 119, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 390, 78, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 389, 4, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 388, 106, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 387, 53, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 386, 65, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 385, 59, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 384, 100, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 383, 94, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 382, 78, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 381, 108, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 380, 10, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 379, 57, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 378, 77, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 405, 98, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 406, 36, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 407, 27, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 408, 78, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 436, 55, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 435, 8, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 434, 51, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 433, 7, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 432, 80, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 431, 112, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 430, 82, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 429, 56, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 428, 70, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 427, 68, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 426, 43, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 425, 51, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 424, 57, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 376, 69, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 423, 2, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 421, 60, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 420, 15, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 419, 19, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 418, 8, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 417, 38, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 416, 53, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 415, 6, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 414, 47, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 413, 37, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 412, 1, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 411, 109, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 410, 6, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 409, 37, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 422, 89, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 251, 119, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 250, 118, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 249, 7, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 91, 21, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 90, 105, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 89, 96, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 88, 119, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 87, 24, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 86, 51, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 85, 118, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 84, 83, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 83, 63, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 82, 113, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 81, 109, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 80, 53, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 79, 104, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 78, 12, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 77, 5, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 76, 9, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 75, 22, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 74, 67, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 73, 47, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 72, 42, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 71, 88, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 70, 68, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 69, 61, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 68, 101, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 67, 86, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 66, 58, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 65, 72, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 92, 104, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 64, 12, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 93, 62, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 95, 89, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 122, 10, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 121, 36, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 120, 89, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 119, 98, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 118, 88, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 117, 104, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 116, 86, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 115, 7, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 114, 98, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 113, 16, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 112, 116, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 111, 24, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 110, 24, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 109, 40, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 108, 82, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 107, 51, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 106, 2, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 105, 99, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 104, 60, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 103, 27, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 102, 19, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 101, 26, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 100, 19, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 99, 12, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 98, 119, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 97, 114, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 96, 52, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 94, 9, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 63, 101, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 62, 83, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 61, 101, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 28, 112, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 27, 83, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 26, 6, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 25, 50, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 24, 111, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 23, 40, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 22, 97, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 21, 2, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 20, 88, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 19, 42, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 18, 26, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 17, 91, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 16, 32, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 15, 59, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 14, 76, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 13, 65, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 12, 52, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 11, 31, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 10, 85, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 9, 72, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 8, 10, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 7, 116, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 6, 79, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 5, 93, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 4, 105, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 3, 56, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 2, 43, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 29, 77, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 30, 73, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 31, 118, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 32, 106, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 60, 113, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 59, 17, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 58, 102, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 57, 63, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 56, 45, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 55, 37, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 54, 28, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 53, 68, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 52, 67, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 51, 115, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 50, 63, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 49, 54, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 48, 68, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 123, 2, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 47, 114, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 45, 81, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 44, 68, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 43, 108, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 42, 80, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 41, 102, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 40, 91, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 39, 10, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 38, 97, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 37, 9, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 36, 95, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 35, 3, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 34, 96, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 33, 81, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 46, 37, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 124, 95, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 125, 5, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 126, 26, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 216, 78, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 215, 86, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 214, 93, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 213, 24, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 212, 92, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 211, 38, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 210, 43, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 209, 115, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 208, 24, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 207, 33, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 206, 118, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 205, 76, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 204, 49, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 203, 16, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 202, 98, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 201, 36, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 200, 22, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 199, 23, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 198, 39, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 197, 5, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 196, 10, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 195, 89, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 194, 51, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 193, 56, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 192, 47, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 191, 24, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 190, 109, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 217, 81, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 218, 74, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 219, 87, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 220, 77, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 248, 55, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 247, 105, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 246, 36, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 245, 66, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 244, 20, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 243, 56, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 242, 71, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 241, 77, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 240, 21, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 239, 103, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 238, 89, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 237, 85, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 236, 64, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 189, 10, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 235, 24, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 233, 67, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 232, 100, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 231, 15, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 230, 80, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 229, 9, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 228, 63, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 227, 34, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 226, 51, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 225, 63, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 224, 31, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 223, 111, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 222, 16, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 221, 42, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 234, 85, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 499, 30, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 188, 32, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 186, 51, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 153, 110, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 152, 80, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 151, 72, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 150, 105, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 149, 18, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 148, 83, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 147, 90, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 146, 51, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 145, 98, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 144, 87, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 143, 29, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 142, 53, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 141, 51, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 140, 113, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 139, 85, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 138, 53, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 137, 30, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 136, 16, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 135, 94, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 134, 118, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 133, 70, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 132, 112, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 131, 62, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 130, 60, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 129, 108, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 128, 112, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 127, 53, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 154, 105, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 155, 119, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 156, 88, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 157, 33, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 185, 119, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 184, 89, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 183, 100, "Pink" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 182, 14, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 181, 95, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 180, 88, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 179, 29, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 178, 5, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 177, 69, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 176, 84, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 175, 16, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 174, 41, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 173, 69, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 187, 99, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 172, 56, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 170, 12, "Red" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 169, 86, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 168, 115, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 167, 78, "Brown" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 166, 117, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 165, 39, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 164, 41, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 163, 114, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 162, 104, "Yellow" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 161, 16, "Purple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 160, 17, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 159, 70, "Orange" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 158, 71, "Green" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 171, 87, "Blue" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FavoriteColor" },
                values: new object[] { 500, 111, "Brown" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
