//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Project2_Sem3.Models;
//using System;
//using System.Linq;

//namespace Project2_Sem3.Data
//{
//    public static class SeedData
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using var context = new AppDbContext(
//                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

//            // Look for any employees
//            if (context.Employees.Any())
//            {
//                return; 
//            }

//            var userManager = serviceProvider.GetRequiredService<UserManager<Employee>>();

//            // Create employees
//            var employees = new Employee[]
//            {
//                new Employee
//                {
                  
//                    Name = "Bun Laura",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-01.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Bun Hara",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-02.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Mab Jahgy",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-03.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "kan BUug",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-04.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Hanh Jsi",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-05.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Ks Haby",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-06.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Kja Xag",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-07.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Rva Ham",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-08.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Ea Chu",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-09.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Bahu Fy",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-10.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Uab Bak",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-11.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Ta Ha",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-12.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Kab Banh",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-13.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Cag Hai",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-14.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Jauu Ban",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-15.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Baj Mabj",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-16.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Hani Bahy",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-17.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Lanu Trae",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-18.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Tayu Bau",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-19.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                },
//                new Employee
//                {

//                    Name = "Caf Dar",
//                    Address = "123 Main Street",
//                    Image = "/images/team/team-20.jpg",
//                    ContactNumber = "1234567890",
//                    EducationalQualification = "Bachelor's Degree",
//                    EmployeeCode = "EMP001",
//                    Department = "Director",
//                    Role = "Developer",
//                    Grade = "A",
//                    Client = "Client A",
//                    Achievements = "Completed project X"
//                }
                
//            };

//            context.Employees.AddRange(employees);
//            context.SaveChanges();

//        }
//    }
//}

