using Microsoft.AspNetCore.Mvc;
using StudentAttendenceDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StudentAttendanceDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendenceDetailsModel> Get()
        {
            StudentAttendenceDetailsModel attendanceObj1 = new StudentAttendenceDetailsModel();
            StudentAttendenceDetailsModel attendanceObj2 = new StudentAttendenceDetailsModel();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Vishal";
            attendanceObj1.AttendencePercentage = 83.02;
            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Shubham";
            attendanceObj2.AttendencePercentage = 71.02;

            List<StudentAttendenceDetailsModel> listObj = new List<StudentAttendenceDetailsModel>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }
    }
}