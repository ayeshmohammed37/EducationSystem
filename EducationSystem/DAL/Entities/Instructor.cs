using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationSystem.DAL.Entities
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual Department Department { get; set; }


    }
}
