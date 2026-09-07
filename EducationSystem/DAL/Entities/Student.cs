using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationSystem.DAL.Entities
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get 
            { 
                return $"{FirstName} {LastName}"; 
            }
        }


        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
