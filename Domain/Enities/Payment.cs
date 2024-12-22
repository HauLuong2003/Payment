using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class Payment : BaseAuditableEntity
    {
        [Key, StringLength(10)]
        public string PaymentId { get; set; } = null!;
        [StringLength(250)]
        public string PaymentConent { get; set; } = null!;
        [StringLength(100)]
        public string? PaymentCurrency { get; set; } = null!;
        [StringLength(10)]
        public string PaymentRefId { get; set; } = null!;
        
        public decimal RequiredAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime ExpireDate {  get; set; }
        [StringLength(15)]
        public string? PaymentLanguage { get; set; } = null!;
        public decimal PaidAmount { get; set; }
        [StringLength(100)]
        public string PaymentStatus { get; set; } = null!;
        [StringLength (255)]
        public string PaymentLastMessage { get; set; } = null!;
        public string MechantId { get; set; } = null!;
        public Merchant Merchant { get; set; } = null!;

        public string PaymentDestinationId { get; set; } = null!;
        public PaymentDestination PaymentDestination { get; set; } = null!;
        public ICollection<PaymentNotification> Notification { get; set; } = new List<PaymentNotification>();
        public ICollection<PaymentSignature> Signature { get; set; } = new List<PaymentSignature>();
        public ICollection<PaymentTransaction> Transaction { get; set; } = new List<PaymentTransaction>();
    }
}
