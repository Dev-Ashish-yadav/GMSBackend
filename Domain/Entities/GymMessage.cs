using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GymMessage
    {
        public int Id { get; set; }
        public int GymID { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string MessageMode {  get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
