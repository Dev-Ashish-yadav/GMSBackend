using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GymMember
    {
        public int Id { get; set; }
        public int GymId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; } 
        public string PanCard { get; set; }
        public string AdharCard { get; set; }
        public string ProfilePhoto { get; set; }
        public string MedicalIssue {  get; set; }
        public string MedicalIssueDescription { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GymPlanID { get; set; }
        public Decimal Amount {  get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
