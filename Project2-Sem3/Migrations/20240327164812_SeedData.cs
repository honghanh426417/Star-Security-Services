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
                    Sex = table.Column<string>(type: "TEXT", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceImg = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Achievements", "Address", "Client", "ContactNumber", "Department", "EducationalQualification", "EmployeeCode", "Grade", "Image", "Name", "Role", "Sex" },
                values: new object[,]
                {
                    { "G001", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-01.jpg", "Bun Laura", "Developer", "male" },
                    { "G002", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-02.jpg", "Bun Hara", "Developer", "male" },
                    { "G003", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-03.jpg", "Mab Jahgy", "Developer", "male" },
                    { "G004", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-04.jpg", "kan BUug", "Developer", "male" },
                    { "G005", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-05.jpg", "Hanh Jsi", "Developer", "male" },
                    { "G006", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-06.jpg", "Ks Haby", "Developer", "male" },
                    { "G007", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-07.jpg", "Kja Xag", "Developer", "male" },
                    { "G008", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-08.jpg", "Rva Ham", "Developer", "male" },
                    { "G009", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-09.jpg", "Ea Chu", "Developer", "male" },
                    { "G010", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-10.jpg", "Bahu Fy", "Developer", "male" },
                    { "G011", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-11.jpg", "Uab Bak", "Developer", "male" },
                    { "G012", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-12.jpg", "Ta Ha", "Developer", "male" },
                    { "G013", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-13.jpg", "Kab Banh", "Developer", "male" },
                    { "G014", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-14.jpg", "Cag Hai", "Developer", "male" },
                    { "G015", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-15.jpg", "Jauu Ban", "Developer", "male" },
                    { "G016", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-16.jpg", "Baj Mabj", "Developer", "male" },
                    { "G017", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-17.jpg", "Hani Bahy", "Developer", "male" },
                    { "G018", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-18.jpg", "Lanu Trae", "Developer", "male" },
                    { "G019", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-19.jpg", "Tayu Bau", "Developer", "male" },
                    { "G020", "Completed project X", "123 Main Street", "Client A", "1234567890", "Director", "Bachelor's Degree", "EMP001", "A", "/images/team/team-20.jpg", "Caf Dar", "Developer", "male" }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Description", "Name", "ServiceImg" },
                values: new object[,]
                {
                    { 1, "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization.", "Private Security", "/images/serviece/service-01.jpg" },
                    { 2, "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization.", "Transport Security", "/images/serviece/service-02.jpg" },
                    { 3, "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization.", "Home Security", "/images/serviece/service-03.jpg" },
                    { 4, "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization.", "Self Security", "/images/serviece/service-04.jpg" },
                    { 5, "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization.", "Offical Security", "/images/serviece/service-06.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
