using ProfCourses.Models;
using ProfCourses.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProfCourses.Tests
{
    public class StudentTest
    {
        [Fact]
        public void ClassMapperTestCourseSucess()
        {
            StudentViewModel stVm = new StudentViewModel() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Student st1 = new Student();
            st1.ClassesMapper(stVm);

            Student st2 = new Student() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Assert.Equal(st1.Course, st2.Course);
        }

        [Fact]
        public void ClassMapperTestCourseFail()
        {
            StudentViewModel stVm = new StudentViewModel() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.Management };
            Student st1 = new Student();
            st1.ClassesMapper(stVm);

            Student st2 = new Student() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 4444-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Assert.NotEqual(st1.Course, st2.Course);
        }

        [Fact]
        public void ClassMapperTestEmailSuccess()
        {
            StudentViewModel stVm = new StudentViewModel() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Student st1 = new Student();
            st1.ClassesMapper(stVm);

            Student st2 = new Student() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 4444-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Assert.Equal(st1.Email, st2.Email);
        }

        [Fact]
        public void ClassMapperTestEmailFailed()
        {
            StudentViewModel stVm = new StudentViewModel() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@hotmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Student st1 = new Student();
            st1.ClassesMapper(stVm);

            Student st2 = new Student() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 4444-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Assert.NotEqual(st1.Email, st2.Email);
        }

        [Fact]
        public void ClassMapperTestNameSuccess()
        {
            StudentViewModel stVm = new StudentViewModel() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Student st1 = new Student();
            st1.ClassesMapper(stVm);

            Student st2 = new Student() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 4444-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Assert.Equal(st1.Name, st2.Name);
        }

        [Fact]
        public void ClassMapperTestNameFailed()
        {
            StudentViewModel stVm = new StudentViewModel() { Name = "Leonardo de Souza", Email = "leodeoliveira.info@hotmail.com", Phone = "(47) 99968-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Student st1 = new Student();
            st1.ClassesMapper(stVm);

            Student st2 = new Student() { Name = "Leonardo de Oliveira", Email = "leodeoliveira.info@gmail.com", Phone = "(47) 4444-2720", Course = Models.Enums.CoursesEnum.DevSoftware };
            Assert.NotEqual(st1.Email, st2.Email);
        }

    }
}
