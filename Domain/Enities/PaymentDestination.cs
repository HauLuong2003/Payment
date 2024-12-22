using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enities
{
    public class PaymentDestination : BaseAuditableEntity
    {
        [Key, StringLength(10)]
        public string Id { get; set; } = null!;
        [StringLength(255)]
        public string DesLogo { get; set; } = null!;
        [StringLength(255)]
        public string DesShortName { get; set; } = null!;
        [StringLength(255)]
        public string DesName { get; set; } = null!;
        public int DesSortIndex { get; set; } 

        public string ParentId { get; set; } = null!;
        public PaymentDestination PaymentDestinations { get; set; } = null!;
        public ICollection<PaymentDestination> Destinations = new List<PaymentDestination>();

        public bool IsActive { get; set; }
        public ICollection<Payment> payments { get; set; } = new List<Payment>();
    }
}
