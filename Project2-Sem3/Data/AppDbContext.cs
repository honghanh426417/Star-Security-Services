using Microsoft.EntityFrameworkCore;
using Project2_Sem3.Models;


namespace Project2_Sem3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = "G001",
                    Name = "Bun Laura",
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
