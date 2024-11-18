using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GymFeesStructure
    {
        public int Id { get; set; }
        public int GymId {  get; set; }
        public string PlanName {  get; set; }
        public int Duration { get; set; }
        public decimal Amount {  get; set; }
        public string Status {  get; set; }

    }
}
