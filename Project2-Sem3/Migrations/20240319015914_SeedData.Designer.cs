﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2_Sem3.Data;

#nullable disable

namespace Project2_Sem3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240319015914_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Project2_Sem3.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Achievements")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Client")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationalQualification")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "G001",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-01.jpg",
                            Name = "Bun Laura",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G002",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-02.jpg",
                            Name = "Bun Hara",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G003",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-03.jpg",
                            Name = "Mab Jahgy",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G004",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-04.jpg",
                            Name = "kan BUug",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G005",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-05.jpg",
                            Name = "Hanh Jsi",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G006",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-06.jpg",
                            Name = "Ks Haby",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G007",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-07.jpg",
                            Name = "Kja Xag",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G008",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-08.jpg",
                            Name = "Rva Ham",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G009",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-09.jpg",
                            Name = "Ea Chu",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G010",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-10.jpg",
                            Name = "Bahu Fy",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G011",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-11.jpg",
                            Name = "Uab Bak",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G012",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-12.jpg",
                            Name = "Ta Ha",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G013",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-13.jpg",
                            Name = "Kab Banh",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G014",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-14.jpg",
                            Name = "Cag Hai",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G015",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-15.jpg",
                            Name = "Jauu Ban",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G016",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-16.jpg",
                            Name = "Baj Mabj",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G017",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-17.jpg",
                            Name = "Hani Bahy",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G018",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-18.jpg",
                            Name = "Lanu Trae",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G019",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-19.jpg",
                            Name = "Tayu Bau",
                            Role = "Developer"
                        },
                        new
                        {
                            Id = "G020",
                            Achievements = "Completed project X",
                            Address = "123 Main Street",
                            Client = "Client A",
                            ContactNumber = "1234567890",
                            Department = "Director",
                            EducationalQualification = "Bachelor's Degree",
                            EmployeeCode = "EMP001",
                            Grade = "A",
                            Image = "/images/team/team-20.jpg",
                            Name = "Caf Dar",
                            Role = "Developer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
