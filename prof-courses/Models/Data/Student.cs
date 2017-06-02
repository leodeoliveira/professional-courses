using ProfCourses.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfCourses.Models.Data
{
    public class Student
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual CoursesEnum Course {get;set;}
        
        public void ClassesMapper(StudentViewModel model)
        {
            this.Name = model.Name;
            this.Email = model.Email;
            this.Phone = model.Phone;
            this.Course = model.Course;
        }
    }
}
