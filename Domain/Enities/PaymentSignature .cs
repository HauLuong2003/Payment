using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class PaymentSignature : BaseAuditableEntity
    {
        [Key, StringLength(10)]
        public string Id { get; set; } = null!;
        [StringLength(500)]
        public string? SignValue { get; set; } = null!;
        [StringLength(50)]
        public string? SignAlgo { get; set; } = null!;
        public DateTime? SignDate { get; set; }
        [StringLength(50)]
        public string SignOwn { get; set; } = null!;
        public string PaymentId { get; set; } = null!;
        public Payment Payment { get; set; } = null!;
    }
}
