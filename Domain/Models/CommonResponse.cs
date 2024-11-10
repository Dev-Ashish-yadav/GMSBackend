using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CommonResponse
    {
        public int Code { get; set; }
        public object Data { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
    }
}
