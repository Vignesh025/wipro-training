using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplication_MVC_demo.Models;

namespace WebApplication_MVC_demo.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents;

        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student() { StudentId = 101, Name = "Cristiano", Branch = "CSE", Section = "A" , Gender="Male"},
                new Student() { StudentId = 101, Name = "Lionel", Branch = "IT", Section = "B" , Gender="Male"},
                new Student() { StudentId = 101, Name = "Neymar", Branch = "CSE", Section = "A" , Gender="Male"},
                new Student() { StudentId = 101, Name = "Ellyse", Branch = "ECE", Section = "C" , Gender="Male"},
                new Student() { StudentId = 101, Name = "Perry", Branch = "CSE", Section = "A" , Gender="Male"},
            };
        }
        public ViewResult Index()
        {
            return View(listStudents);
        }

        public ViewResult Details(int Id)
        {
            var studentDetails = listStudents.FirstOrDefault(std => std.StudentId == Id);
            return View(studentDetails);
        }
    }
}
