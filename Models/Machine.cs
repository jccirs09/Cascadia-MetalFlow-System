using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cascadia_MetalFlow_System.Models
{
    public class Machine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public int CompanyBranchId { get; set; }

        [ForeignKey("CompanyBranchId")]
        public CompanyBranch? CompanyBranch { get; set; }
    }
}
