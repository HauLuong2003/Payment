using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class PaymentNotification : BaseAuditableEntity
    {
        [Key, StringLength(10)]
        public string Id { get; set; } = null!;
        [StringLength(10)]
        public string PaymentRefId { get; set; } = null!;
        [StringLength(50)]
        public string NotiDate { get; set; } = null!;
        [StringLength(50)]
        public string NotiAmount { get; set;} = null!;
        [StringLength(50)]
        public string NotiContent{ get; set;} = null!;
        [StringLength(50)]
        public string NotiMessage { get; set;} = null!;
        [StringLength(50)]
        public string NotiSignature { get; set;} = null!;
        [StringLength(50)]
        public string NotiStatus { get; set; } = null!;
        [StringLength(50)]
        public string NotiResDate { get; set; } = null!;

        public string PaymentId { get; set; } = null!;
        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; } = null!;
    }
}
