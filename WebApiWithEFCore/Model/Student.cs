using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithEFCore.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [StringLength(70)]
        public string FatherName { get; set; }
        public University University { get; set; }
        [DisplayName("FK_UniversityId")]
        public int UniversityId { get; set; }
    }
}
