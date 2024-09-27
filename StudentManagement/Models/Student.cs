using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name="Student Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name="Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name="Email Address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
