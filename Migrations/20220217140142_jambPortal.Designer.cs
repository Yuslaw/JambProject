﻿// <auto-generated />
using JambRegProject.Contxt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JambRegProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220217140142_jambPortal")]
    partial class jambPortal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("JambRegProject.Model.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("AdminId")
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("text");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Oyo, Ibadan",
                            AdminId = "Jamb23456",
                            Age = 56,
                            Email = "Dibu@gmail.com",
                            FirstName = "Dibu",
                            Gender = 2,
                            LastName = "Ojerinde",
                            PhoneNum = "0908887766",
                            Pin = 1234
                        });
                });

            modelBuilder.Entity("JambRegProject.Model.Center", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AvailableSpace")
                        .HasColumnType("int");

                    b.Property<string>("CenterName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("JambRegProject.Model.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("JambRegProject.Model.School", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SchoolName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("JambRegProject.Model.SchoolCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SchoolId");

                    b.ToTable("SchoolCourses");
                });

            modelBuilder.Entity("JambRegProject.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Centerid")
                        .HasColumnType("int");

                    b.Property<string>("DateOfExam")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("JambRegNo")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("text");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Centerid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("JambRegProject.Model.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("JambRegProject.Model.StudentSchool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentSchools");
                });

            modelBuilder.Entity("JambRegProject.Model.StudentSubject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Studentid")
                        .HasColumnType("int");

                    b.Property<int>("Subjectid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Studentid");

                    b.HasIndex("Subjectid");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("JambRegProject.Model.Subject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("JambRegProject.Model.SchoolCourse", b =>
                {
                    b.HasOne("JambRegProject.Model.Course", "Course")
                        .WithMany("SchoolCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JambRegProject.Model.School", "School")
                        .WithMany("SchoolCourses")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("School");
                });

            modelBuilder.Entity("JambRegProject.Model.Student", b =>
                {
                    b.HasOne("JambRegProject.Model.Center", "Center")
                        .WithMany("Students")
                        .HasForeignKey("Centerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("JambRegProject.Model.StudentCourse", b =>
                {
                    b.HasOne("JambRegProject.Model.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JambRegProject.Model.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("JambRegProject.Model.StudentSchool", b =>
                {
                    b.HasOne("JambRegProject.Model.School", "School")
                        .WithMany("StudentSchools")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JambRegProject.Model.Student", "Student")
                        .WithMany("StudentSchools")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("JambRegProject.Model.StudentSubject", b =>
                {
                    b.HasOne("JambRegProject.Model.Student", "Student")
                        .WithMany("Studentsubject")
                        .HasForeignKey("Studentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JambRegProject.Model.Subject", "Subject")
                        .WithMany("Studentsubject")
                        .HasForeignKey("Subjectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("JambRegProject.Model.Center", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("JambRegProject.Model.Course", b =>
                {
                    b.Navigation("SchoolCourses");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("JambRegProject.Model.School", b =>
                {
                    b.Navigation("SchoolCourses");

                    b.Navigation("StudentSchools");
                });

            modelBuilder.Entity("JambRegProject.Model.Student", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("StudentSchools");

                    b.Navigation("Studentsubject");
                });

            modelBuilder.Entity("JambRegProject.Model.Subject", b =>
                {
                    b.Navigation("Studentsubject");
                });
#pragma warning restore 612, 618
        }
    }
}
