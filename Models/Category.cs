using System.ComponentModel.DataAnnotations;

namespace UniversityDbApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        // 1-to-N: бір санатта көп тауар
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
