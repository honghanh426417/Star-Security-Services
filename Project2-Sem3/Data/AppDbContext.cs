using Microsoft.EntityFrameworkCore;
using Project2_Sem3.Models;


namespace Project2_Sem3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().ToTable("Service");
            modelBuilder.Entity<Service>().HasKey(s => s.Id);

            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 001,
                    Name = "Private Security",
                    ServiceImg = "/images/serviece/service-01.jpg",
                    Description = "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization."
                },
                new Service
                {
                    Id = 002,
                    Name = "Transport Security",
                    ServiceImg = "/images/serviece/service-02.jpg",
                    Description = "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization."
                }, new Service
                {
                    Id = 003,
                    Name = "Home Security",
                    ServiceImg = "/images/serviece/service-03.jpg",
                    Description = "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization."
                }, new Service
                {
                    Id = 004,
                    Name = "Self Security",
                    ServiceImg = "/images/serviece/service-04.jpg",
                    Description = "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization."
                }, new Service
                {
                    Id = 005,
                    Name = "Offical Security",
                    ServiceImg = "/images/serviece/service-06.jpg",
                    Description = "At [Company Name], we understand the paramount importance of safeguarding your assets, whether they be physical locations, data, or personnel. That's why we are proud to offer comprehensive security solutions tailored to meet your specific needs.\n\nOur team of highly trained security professionals is dedicated to providing top-tier protection for your business, ensuring peace of mind for you and your stakeholders. From on-site security personnel to advanced surveillance systems and access control measures, we employ the latest technologies and methodologies to mitigate risks and prevent unauthorized access.\n\nWith our proactive approach and unwavering commitment to excellence, you can trust us to safeguard your interests and uphold the highest standards of security at all times. Partner with us today and experience the difference that professional security services can make for your organization."
                }
                );

            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = "G001",
                    Name = "Bun Laura",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-01.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G002",
                    Name = "Bun Hara",
                    Sex = "male",

                    Address = "123 Main Street",
                    Image = "/images/team/team-02.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G003",
                    Name = "Mab Jahgy",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-03.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G004",
                    Name = "kan BUug",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-04.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G005",
                    Name = "Hanh Jsi",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-05.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G006",
                    Name = "Ks Haby",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-06.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G007",
                    Name = "Kja Xag",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-07.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G008",
                    Name = "Rva Ham",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-08.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G009",
                    Name = "Ea Chu",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-09.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G010",
                    Name = "Bahu Fy",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-10.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G011",
                    Name = "Uab Bak",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-11.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G012",
                    Name = "Ta Ha",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-12.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G013",
                    Name = "Kab Banh",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-13.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G014",
                    Name = "Cag Hai",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-14.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G015",
                    Name = "Jauu Ban",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-15.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G016",
                    Name = "Baj Mabj",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-16.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G017",
                    Name = "Hani Bahy",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-17.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G018",
                    Name = "Lanu Trae",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-18.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G019",
                    Name = "Tayu Bau",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-19.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                },
                new Employee
                {
                    Id = "G020",
                    Name = "Caf Dar",
                    Sex = "male",
                    Address = "123 Main Street",
                    Image = "/images/team/team-20.jpg",
                    ContactNumber = "1234567890",
                    EducationalQualification = "Bachelor's Degree",
                    EmployeeCode = "EMP001",
                    Department = "Director",
                    Role = "Developer",
                    Grade = "A",
                    Client = "Client A",
                    Achievements = "Completed project X"
                }
                ) ;
            base.OnModelCreating(modelBuilder);




        }
    }
}
