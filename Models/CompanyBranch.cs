using System.ComponentModel.DataAnnotations;

namespace Cascadia_MetalFlow_System.Models
{
    public class CompanyBranch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Location { get; set; }
    }
}
