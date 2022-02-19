using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JambRegProject.Model;
using System.Threading;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using JambRegProject.Enums;

namespace JambRegProject.Contxt
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL
            ("server=localhost;user=root;database=RegPortal;port=3306;password=Adetola200910");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Admin>().HasData(
                   new Admin
                   {
                       Id = 1,
                       FirstName = "Dibu",
                       LastName = "Ojerinde",
                       Address = "Oyo, Ibadan",
                       Age = 56,
                       Email = "Dibu@gmail.com",
                       PhoneNum = "0908887766",
                       Pin = 1234,
                       Gender = Gender.Female,
                       AdminId = "Jamb23456",


                   }
               );
        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<StudentSchool> StudentSchools { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<SchoolCourse> SchoolCourses { get; set; }


        public override DatabaseFacade Database => base.Database;

        public override ChangeTracker ChangeTracker => base.ChangeTracker;

        public override IModel Model => base.Model;

        public override DbContextId ContextId => base.ContextId;
    }
}