using System.ComponentModel.DataAnnotations;

namespace UniversityDbApp.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        // 1-to-N: бір кафедрада көп оқытушы
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
