using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JambRegProject.Contxt;
using JambRegProject.Model;
using JambRegProject.Repositories;
using Microsoft.EntityFrameworkCore;
using JambRegProject.Enums;
namespace JambRegProject
{
    public class Menu
    {
        private readonly ApplicationDbContext context;
        private readonly CenterRepository CenterRepository;
        private readonly SubjectRepository SubjectRepository;
        private readonly SchoolRepository SchoolRepository;
        private readonly StudentRepository StudentRepository;
        private readonly CourseRepository CourseRepository;
        private readonly AdminRepository AdminRepository;
        


        public Menu()
        {
            context = new ApplicationDbContext();
            CenterRepository = new CenterRepository(context);
            SchoolRepository = new SchoolRepository(context);
            SubjectRepository = new SubjectRepository(context);
            StudentRepository = new StudentRepository(context);
            CourseRepository = new CourseRepository(context);
            AdminRepository = new AdminRepository(context);
          
        }




        public void MyMenu()
        {
            bool big = true;
            while (big)
            {
                Console.WriteLine($"Welcome to Jamb Website! \npress 1 for Admin Menu\nPress 2 for Student Menu\npress 3 to Exit");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    AdminMenu();
                  
                }
                else if (option == 2)
                {
                    StudentMenu();
                }
                else if (option == 3)
                {
                    big = false;
                }
            }

        }




        public void AdminMenu()
        {
        
            Console.WriteLine("**********Welcome to Jamb Portal********");
            Console.WriteLine("Enter your pin");
            var pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Email");
            var email = Console.ReadLine();
            var admin = AdminRepository.Get(x => x.Pin == pin && x.Email == email);

            if (admin == null)
            {
                Console.WriteLine("wrong pin or email, try again!");
            }
            else
            {
                while(true)
                {
                    Console.WriteLine($"Hey, {admin.FirstName}  Welcome to your Jamb Portal");
                    Console.WriteLine("\nTo enter Center Menu press 1\nTo enter School Menu press 2\nTo enter Subject Menu press 3\nTo enter Student Menu press 4\nTo enter Course Menu press 5\n 0 to exit");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine("Press\n1 to create center\n2 to update center\n3 to delete center\n4 to Get all available centers\n5 to get a particular center");
                        int opton = int.Parse(Console.ReadLine());
                        if (opton == 1)
                        {
                            Console.WriteLine("Enter name of Center: ");
                            var name = Console.ReadLine();
                            Console.WriteLine("Enter available space: ");
                            var space = int.Parse(Console.ReadLine());

                            Center center = new Center
                            {
                                CenterName = name,
                                AvailableSpace = space
                            };
                            CenterRepository.Create(center);
                            Console.WriteLine("Center created successfully!");
                        
                        }
                        else if (opton == 2)
                        {
                            Console.WriteLine("Enter center id to get center: ");
                            int id = int.Parse(Console.ReadLine());
                            var center = CenterRepository.Get(id);
                            if (center == null)
                            {
                                Console.WriteLine("Center not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter new name: ");
                                var newName = Console.ReadLine();
                                center.CenterName = newName;
                                Console.WriteLine("Enter new space: ");
                                var newSpace = int.Parse(Console.ReadLine());
                                center.AvailableSpace= newSpace;
                                CenterRepository.Update(center);
                                Console.WriteLine("Center updated successfully!");
                            
                                

                            }
                        }
                        else if (opton == 3)
                        {
                            Console.WriteLine("Enter center id to get center: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CenterRepository.Delete(id)) Console.WriteLine("Center deleted successfully!");

                            else Console.WriteLine("Center not found!");
                        
                        }
                        else if (opton == 4)
                        {
                            var centers = CenterRepository.GetMany(c => true);
                            foreach (var item in centers) Console.WriteLine(item.CenterName);

                        }
                        else if (opton == 5)
                        {
                            Console.WriteLine("Enter center id to get center: ");
                            int id = int.Parse(Console.ReadLine());
                            var center = CenterRepository.Get(id);
                            if (center == null)
                            {
                                Console.WriteLine("center not found!");
                            }
                            else Console.WriteLine(center.CenterName);
                        
                        }
                       
                    
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Enter\n1 to create school\n2 to update school\n3 to delete school\n4 to Get all available schools\n5 to get a particular school");
                        int opton = int.Parse(Console.ReadLine());
                        if (opton == 1)
                        {
                            Console.WriteLine("Enter name of School: ");
                            var schoolname = Console.ReadLine();

                            School school = new School
                            {
                                SchoolName = schoolname
                            };
                            SchoolRepository.Create(school);
                            Console.WriteLine("School created successfully!");
                        
                        }
                        else if (opton == 2)
                        {
                            Console.WriteLine("Enter school id to get school: ");
                            int id = int.Parse(Console.ReadLine());
                            var school = SchoolRepository.Get(id);
                            if (school == null)
                            {
                                Console.WriteLine("School not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter new name: ");
                                var newName = Console.ReadLine();
                                school.SchoolName = newName;
                                SchoolRepository.Update(school);
                            } Console.WriteLine("School updated successfully!");
                        
                        }
                        else if (opton == 3)
                        {
                            Console.WriteLine("Enter school id to get school: ");
                            int id = int.Parse(Console.ReadLine());
                            if (SchoolRepository.Delete(id)) Console.WriteLine("School deleted successfully!");
                            else Console.WriteLine("School not found!");
                        
                        }
                        else if (opton == 4)
                        {
                            var schools = SchoolRepository.GetMany(d => true);
                            foreach (var item in schools) Console.WriteLine(item.SchoolName);
                        }
                        else if (opton == 5)
                        {

                            Console.WriteLine("Enter school id to get school: ");
                            int id = int.Parse(Console.ReadLine());
                            var school = SchoolRepository.Get(id);
                            if (school == null)
                            {
                                Console.WriteLine("school not found!");
                            }
                            else Console.WriteLine(school.SchoolName);
                        
                        }
                    
                
                    }

                    else if (input == 3)
                    {
                        Console.WriteLine("Enter\n1 to create subject\n2 to update subject\n3 to delete subject\n4 to Get all available subjects\n5 to get a particular subject");
                        int opton = int.Parse(Console.ReadLine());
                        if (opton == 1)
                        {
                            Console.WriteLine("Enter name of Subject: ");
                            var name = Console.ReadLine();

                            Subject subject = new Subject
                            {
                                SubjectName = name
                            };
                            SubjectRepository.Create(subject);
                            Console.WriteLine("Subject created successfully!");
                        

                        }
                        else if (opton == 2)
                        {
                            Console.WriteLine("Enter Subject id to get subject: ");
                            int id = int.Parse(Console.ReadLine());
                            var subject = SubjectRepository.Get(id);
                            if (subject == null)
                            {
                                Console.WriteLine("Subject not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter new name: ");
                                var newName = Console.ReadLine();
                                subject.SubjectName = newName;
                                SubjectRepository.Update(subject);
                            } Console.WriteLine("Subject updated successfully!");
                        


                        }
                        else if (opton == 3)
                        {
                            Console.WriteLine("Enter subject id to get subject: ");
                            int id = int.Parse(Console.ReadLine());
                            if (SubjectRepository.Delete(id)) Console.WriteLine("Subject deleted successfully!");
                            else Console.WriteLine("Subject not found!");
                        
                        }
                        else if (opton == 4)
                        {
                            var subjects = SubjectRepository.GetMany(d => true);
                            foreach (var item in subjects) Console.WriteLine(item.SubjectName);
                        }
                        else if (opton == 5)
                        {
                            Console.WriteLine("Enter subject id to get subject: ");
                            int id = int.Parse(Console.ReadLine());
                            var subject = SubjectRepository.Get(id);
                            if (subject == null)
                            {
                                Console.WriteLine("subject not found!");
                            }
                            else Console.WriteLine(subject.SubjectName);
                        
                        }
    
                    }


                    else if (input == 4)
                    {
                        Console.WriteLine("Enter\n1 to get all the student in a particular center\n2 to get the subject offered by a particular student\n3 to students offering a particular subject\n4 to get all students");
                        int opton = int.Parse(Console.ReadLine());


                        if (opton == 1)
                        {
                            Console.WriteLine("Enter center id to get students: ");
                            int id = int.Parse(Console.ReadLine());
                            var students = StudentRepository.GetStudentsByCenter(id);
                            foreach (var item in students) Console.WriteLine($"{item.FirstName} {item.LastName}");

                        }
                        else if (opton == 2)
                        {
                            Console.WriteLine("Enter student id to get subjects offering: ");
                            int id = int.Parse(Console.ReadLine());
                            var studentSubject = SubjectRepository.GetSubjectByStudentId(id);
                            foreach (var item in studentSubject) Console.WriteLine(item.SubjectName);

                        }
                        else if (opton == 3)
                        {
                            Console.WriteLine("Enter subject id to get students offering subject: ");
                            int id = int.Parse(Console.ReadLine());
                            var studentsInSubject = StudentRepository.GetStudentsBySubjectId(id);
                            foreach (var item in studentsInSubject) Console.WriteLine(item.FirstName);
                        }
                        else if (opton==4)
                        {
                            var allStudents = StudentRepository.GetMany(d => true);
                            foreach (var item in allStudents) Console.WriteLine(item.FirstName);
                        }
                    

                    }
                    else if (input == 5)
                    {
                        Console.WriteLine("Enter\n1 to create courses to schools\n2 to update course\n3 to delete course\n4 to Get all available courses\n5 to get a particular course");
                        int opton = int.Parse(Console.ReadLine());
                        if (opton == 1)
                        {
                            Console.WriteLine("Enter school id to get school: ");
                            int id = int.Parse(Console.ReadLine());
                            var school = SchoolRepository.Get(id);
                            if (school == null)
                            {
                                Console.WriteLine("School not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter name of Course: ");
                                var name = Console.ReadLine();

                                Course course = new Course
                                {
                                    CourseName = name
                                };
                                CourseRepository.Create(course);
                                Console.WriteLine("Course created successfully!");
                            
                            }
                            
                            
                        }
                        else if (opton == 2)
                        {
                            Console.WriteLine("Enter Course id to get course: ");
                            int id = int.Parse(Console.ReadLine());
                            var course = CourseRepository.Get(id);
                            if (course == null)
                            {
                                Console.WriteLine("Course not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter new name: ");
                                var newName = Console.ReadLine();
                                course.CourseName = newName;
                                CourseRepository.Update(course);
                                Console.WriteLine("Course updated successfully!");
                            
                            }
                        }
                        else if (opton == 3)
                        {
                            Console.WriteLine("Enter course id to get course: ");
                            int id = int.Parse(Console.ReadLine());
                            if (CourseRepository.Delete(id)) Console.WriteLine("Course deleted successfully!");
                            else Console.WriteLine("Course not found!");
                        
                        }
                        else if (opton == 4)
                        {
                            var courses = CourseRepository.GetMany(d => true);
                            foreach (var item in courses) Console.WriteLine(item.CourseName);
                        }
                        else if (opton == 5)
                        {
                            Console.WriteLine("Enter course id to get course: ");
                            int id = int.Parse(Console.ReadLine());
                            var course = CourseRepository.Get(id);
                            if (course == null)
                            {
                                Console.WriteLine("course not found!");
                            }
                            else Console.WriteLine(course.CourseName);
                        

                        }
                        
                    }
                    else if (input==0)
                    {
                        MyMenu();
                    }
                }
               


            }

        }
        public void StudentMenu()
        {


            Console.WriteLine($"Welcome to Jamb Official Website!\npress 1 to Login\npress 2 to Go back\n press 3 to Register");
            var option = int.Parse(Console.ReadLine());

            if (option == 1)
             {
                Console.WriteLine("**********Welcome to Jamb Portal********");
                Console.WriteLine("Enter your pin");
                var pin = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Email");
                var email = Console.ReadLine();
                var student = StudentRepository.Get(x => x.Pin == pin && x.Email == email);

                if (student == null)
                {
                    Console.WriteLine("wrong pin or id");
                }
                else
                {
                    while(true)
                    {
                        Console.WriteLine($"Hey, {student.FirstName}  Welcome to your Jamb Portal");
                        Console.WriteLine("Enter 1 to update Student\nEnter 2 to see list of schools \nEnter 3 to see list of courses\nEnter 4 to see list of subjects\nEnter 0 to xit");
                        var input = int.Parse(Console.ReadLine());
                        if (input == 1)
                        {
                            Console.WriteLine("Enter Student id to get student: ");
                            int id = int.Parse(Console.ReadLine());
                            var stu = StudentRepository.Get(id);
                            if (stu == null)
                            {
                                Console.WriteLine("Student not found!");
                            }
                            else
                            {
                                Console.WriteLine("Enter new name: ");
                                var newName = Console.ReadLine();
                                Console.WriteLine("Enter new name: ");
                                var lastName = Console.ReadLine();
                                stu.FirstName = newName;
                                stu.LastName = lastName;
                                StudentRepository.Update(stu);
                                Console.WriteLine("Student updated successfully!");
                            
                            }
                        }
                        else if (input == 2)
                        {

                            var schools = SchoolRepository.GetMany(d => true);
                            foreach (var item in schools) Console.WriteLine(item.SchoolName);
                            
                        }
                        else if (input == 3)
                        {
                            var courses = CourseRepository.GetMany(d => true);
                            foreach (var item in courses) Console.WriteLine(item.CourseName);
                            
                        }
                        else if (input == 4)
                        {
                            var subjects = SubjectRepository.GetMany(d => true);
                            foreach (var item in subjects) Console.WriteLine(item.SubjectName);
                            
                        }
                    
                    }

                }

                }
                else if (option == 2)
                {
                        MyMenu();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter first name of Student: ");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("Enter last name of Student: ");
                    var lastName = Console.ReadLine();
                    Console.WriteLine("Enter Student Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Student Address: ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter Student phone number: ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Enter Student age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student pin: ");
                    int pin = int.Parse(Console.ReadLine());
                    string jambRegNo = GenerateJambReg();
                    Console.WriteLine("Choose your Gender: ");
                    Console.WriteLine("\t1, Male");
                    Console.WriteLine("\t2, Female ");
                    Console.WriteLine("\t3, Rather not specify ");
                    var gender = (Gender)int.Parse(Console.ReadLine());
                    Console.WriteLine("you selected '{0}'", gender.ToString());
                    var examDate = GenerateExaminationDate();
                    Console.WriteLine("available centers");
                    var centers = CenterRepository.GetMany(c => true);
                    foreach (var item in centers) Console.WriteLine($"{item.CenterName} {item.id}");
                    Console.WriteLine("choose by id the centers you want, pick 3: ");
                    List<int> centerId= new List<int>();
                    for(int i =0; i<3;)
                    {
                        Console.WriteLine($"Enter center {i+1}:\t");
                        var centerIdd= int.Parse(Console.ReadLine());
                        var confirm = CenterRepository.Get(centerIdd);
                        if(confirm==null)
                        {
                            Console.WriteLine("center doesnt exist");
                        }
                        else if(AvailableCenterSpace(centerIdd)==false)
                        {
                            Console.WriteLine("Space exceeded!");
                        }
                        else
                        {
                            centerId.Add(centerIdd);
                            i++;
                        }
                    }
                        var centerrId= GenerateCenter(centerId);
                
                    Student student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Address =address,
                        PhoneNum = phone,
                        Pin = pin,
                        Age = age,
                        JambRegNo = jambRegNo,
                        Gender = gender,
                        DateOfExam = examDate,
                        Centerid = centerrId,
                        StudentCourses = new List<StudentCourse>(),
                        StudentSchools = new List<StudentSchool>(),
                        Studentsubject = new List<StudentSubject>()

                    };

                    Console.WriteLine("The available courses are: ");
                    var courses = CourseRepository.GetMany(d => true);
                    foreach (var item in courses) Console.WriteLine(item.CourseName);
                    Console.WriteLine("Choose course of choice: ");
                    for(int i=0; i<2;)
                    {
                        Console.WriteLine($"Enter Course {i+1}:\t");
                        var courseOne = int.Parse(Console.ReadLine());
                        
                        if(courseOne!=0)
                        {
                            var Cour = new StudentCourse()
                            {
                                
                                StudentId = student.Id,
                            
                                CourseId= courseOne,

                            };
                            student.StudentCourses.Add(Cour);
                            i++;
                            

                        }
                        else
                        {
                            
                            Console.WriteLine("Course not found!");
                    
                        }
                        
                    }



                    Console.WriteLine("available schools");
                    var schools = SchoolRepository.GetMany(d => true);
                    foreach (var item in schools) Console.WriteLine(item.SchoolName);
                    Console.WriteLine("choose by id the school you want to offer: ");
                    for(int i=0; i<2;)
                    {
                        Console.WriteLine($"Enter school {i+1}:\t");
                        var schoolId = int.Parse(Console.ReadLine());
                
                        if(schoolId!=0)
                        {
                            var Sch = new StudentSchool()
                            {
                                
                                StudentId = student.Id,
                            
                                SchoolId= schoolId,

                            };
                            student.StudentSchools.Add(Sch);
                            i++;
                            

                        }
                        else
                        {
                            
                            Console.WriteLine("School not found!");
                    
                        }
                    }
                
               
                
                    Console.WriteLine("Available subjects!");
                    var subjects = SubjectRepository.GetMany(d => true);
                    foreach (var item in subjects) Console.WriteLine(item.SubjectName);
                    Console.WriteLine("choose by id the subject you want to offer: ");
                    for(int i=0; i<4;)
                    {
                        Console.WriteLine($"Enter subject {i+1}:\t");
                        var subjectid= int.Parse(Console.ReadLine());
                
                        if(subjectid!=0)
                        {
                            var Stu = new StudentSubject()
                            {
                                
                                Studentid = student.Id,
                            
                                Subjectid = subjectid,

                            };
                            student.Studentsubject.Add(Stu);
                            i++;
                            

                        }
                        else
                        {
                            
                            Console.WriteLine("Subject not found!");
                    
                        }
                    }
              
                    StudentRepository.Create(student);
                    Console.WriteLine("Student created successfully!");
                    Console.WriteLine($"The date of your exam is {GenerateExaminationDate()}");

            }
        }

            public int GenerateCenter(List<int> cen)
            {
                Random rand = new Random();
                var rando = rand.Next(0, cen.Count-1);
                var result = cen[rando];

                return result;
            }
            

            public string GenerateJambReg()
            {
                return $"JAMB/{Guid.NewGuid().ToString().Substring(0, 5)}/";
            }

            public string GenerateExaminationDate()
         {
            var dateTime = DateTime.Now.Date;
            var days = dateTime.AddDays(30);
            var all = days.AddDays(14);
            List<string> examDate = new List<string>();
            for (DateTime i = days; i.Date <= all; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Sunday)
                {
                    string newww = i.ToString();
                    examDate.Add(newww);             
                }
                else
                {
                    continue;
                }
            }
            Random rand = new Random();
            var ran = rand.Next(0, examDate.Count - 1); 
            return examDate[ran];
          }

          public bool AvailableCenterSpace(int id)
          {
            var cent = CenterRepository.Get(id);
            if(cent.AvailableSpace>0)
            {
                return true;
                var centerssInVogue=(cent.AvailableSpace)-1;
                cent.AvailableSpace= centerssInVogue;
                CenterRepository.Update(cent);
            }
            return false;
          }


    }
}


        
    