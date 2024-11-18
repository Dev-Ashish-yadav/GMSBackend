using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gym_Users_master
    {
        public int GU_ID { get; set; }

        public string GU_GM_ID { get; set; }
        public string GU_MOBILE { get; set; }
        public string GU_FIRST_NAME { get; set; }
        public string GU_LAST_NAME { get; set; }
        public string GU_EMAIL { get; set; }
        public string GU_GENDER { get; set; }
        public string GU_P_TYPE { get; set; }
        public string GU_PHOTO { get; set; }
        public string GU_AADHAR { get; set; }
        public string GU_PAN { get; set; }
        public DateTime GU_DOB { get; set; }
        public DateTime GU_CREATE_DATE { get; set; } = DateTime.Now;
        public DateTime GU_UPDATE_DATE { get; set; } = DateTime.Now;
    }
}
