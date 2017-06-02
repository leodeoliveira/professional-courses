using ProfCourses.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfCourses.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [Display(Name= "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [EmailAddress(ErrorMessage = "Este não é um email válido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Este não é um telefone válido.")]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }

        public CoursesEnum Course { get; set; }
    }
}
