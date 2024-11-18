using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gym_Master
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int  Pincode { get; set; }
        public string Logo { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;} = DateTime.Now;
        
    }
}
