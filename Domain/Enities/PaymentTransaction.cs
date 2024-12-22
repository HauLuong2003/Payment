using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class PaymentTransaction : BaseAuditableEntity
    {
        [Key,StringLength(10)]
        public int Id { get; set; }
        [StringLength(250)]
        public string TranMessage { get; set; } = null!;
        [StringLength(500)]
        public string TranPayload { get; set; } = null!;
        [StringLength(15)]
        public string TranStatus { get; set; } = null!;
        public string PaymentId { get; set; } = null!;
        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; } = null!;
    }
}
