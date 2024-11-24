using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IGymAdminMasterRepository
    {
        public Task<GymAdminMaster> GetGymAdminMaster(string username, string password);
    }
}
