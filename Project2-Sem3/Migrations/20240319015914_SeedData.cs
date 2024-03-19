using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project2_Sem3.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EducationalQualification = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeCode = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    Grade = table.Column<string>(type: "TEXT", nullable: true),
                    Client = table.Column<string>(type: "TEXT", nullable: true),
                    Achievements = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Achievements", "Address", "Client", "ContactNumber", "Department", "EducationalQualification", "EmployeeCode", "Grade", "Image", "Name", "Role" },
                values: new object[,]
                {
                    { "G001", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-01.jpg", "Bun Laura", "Developer" },
                    { "G002", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-02.jpg", "Bun Hara", "Developer" },
                    { "G003", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-03.jpg", "Mab Jahgy", "Developer" },
                    { "G004", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-04.jpg", "kan BUug", "Developer" },
                    { "G005", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-05.jpg", "Hanh Jsi", "Developer" },
                    { "G006", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-06.jpg", "Ks Haby", "Developer" },
                    { "G007", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-07.jpg", "Kja Xag", "Developer" },
                    { "G008", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-08.jpg", "Rva Ham", "Developer" },
                    { "G009", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-09.jpg", "Ea Chu", "Developer" },
                    { "G010", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-10.jpg", "Bahu Fy", "Developer" },
                    { "G011", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-11.jpg", "Uab Bak", "Developer" },
                    { "G012", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-12.jpg", "Ta Ha", "Developer" },
                    { "G013", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-13.jpg", "Kab Banh", "Developer" },
                    { "G014", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-14.jpg", "Cag Hai", "Developer" },
                    { "G015", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-15.jpg", "Jauu Ban", "Developer" },
                    { "G016", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-16.jpg", "Baj Mabj", "Developer" },
                    { "G017", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-17.jpg", "Hani Bahy", "Developer" },
                    { "G018", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-18.jpg", "Lanu Trae", "Developer" },
                    { "G019", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-19.jpg", "Tayu Bau", "Developer" },
                    { "G020", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-20.jpg", "Caf Dar", "Developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
