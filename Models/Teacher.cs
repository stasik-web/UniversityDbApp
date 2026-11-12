using System.ComponentModel.DataAnnotations;

namespace UniversityDbApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
