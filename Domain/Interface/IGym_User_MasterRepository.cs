using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IGym_User_MasterRepository
    {
        public Task<bool> AddMembers(Gym_Users_master gym_User_Master);
    }
}
