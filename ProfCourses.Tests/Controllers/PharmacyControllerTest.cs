using ProfCourses.Controllers;
using ProfCourses.Models;
using ProfCourses.Models.Data;
using ProfCourses.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProfCourses.Tests.Controllers
{
    public class PharmacyControllerTest
    {
        [Fact]
        public void CreateStudentTest()
        {
            var controller = new PharmacyController();
            StudentViewModel st = new StudentViewModel() { Name = "João da Silva", Email = "joao@gmail.com", Phone = "47 3434-3434" };
            Student result = controller.CreateStudent(st);

            Assert.Equal(result.Course, CoursesEnum.Pharmacy);
            Assert.Equal(result.Name, st.Name);
            Assert.Equal(result.Email, st.Email);
            Assert.Equal(result.Phone, st.Phone);
        }

        [Fact]
        public void CreateNullStudentTest()
        {
            var controller = new PharmacyController();
            StudentViewModel st = null;
            Student result = controller.CreateStudent(st);
            Assert.Null(result);
        }
    }
}
