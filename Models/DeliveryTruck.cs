using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cascadia_MetalFlow_System.Models
{
    public class DeliveryTruck
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string LicensePlate { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Model { get; set; }

        [Required]
        public int CompanyBranchId { get; set; }

        [ForeignKey("CompanyBranchId")]
        public CompanyBranch? CompanyBranch { get; set; }
    }
}
