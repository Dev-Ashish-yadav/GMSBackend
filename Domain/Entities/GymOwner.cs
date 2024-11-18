using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GymOwner
    {
        public int Id { get; set; }
        public int GymId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mobile {  get; set; }
        public string Email { get; set; }
        public string Gender {  get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PaymentMode { get; set; }
        public string Image {  get; set; }
        public int PlanId {  get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
