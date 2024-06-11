using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee_Attendence.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Designation/Role")]
        public string Designation { get; set; }
    }
}
