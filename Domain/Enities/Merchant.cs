using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class Merchant : BaseAuditableEntity
    {
        [Key,StringLength(10)]
        public string MerchantId { get; set; } = null!;
        [StringLength(150)]
        public string MerchantName { get; set; } = null!;
        [StringLength(255)]
        public string? MerchantWebLink { get; set; } = null!;
        [StringLength(255)]
        public string? MerchantWebUrl { get; set; } = null!;
        [StringLength(255)]
        public string MerchantReturnUrl { get; set; } = null!;
        [StringLength(50)]
        public string SerectKey { get; set; } = null!;
        
        public bool IsActive { get; set; }
        public ICollection<Payment> Payment { get; set; } = new List<Payment>();
    }
}
