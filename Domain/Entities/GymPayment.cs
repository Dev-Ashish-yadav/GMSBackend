using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GymPayment
    {
        public int Id { get; set; }
        public string PaymneMode { get; set; }
        public string PaymentType { get; set; }
        public Decimal Amount {  get; set; }
        public decimal Balance { get; set; }
        public string PaymentStatus {  get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
