using Domain.Entities;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class GymAdminMasterRepository : IGymAdminMasterRepository
    {
        private readonly DataContext _Context;
        public GymAdminMasterRepository(DataContext context)
        {
            _Context = context;
        }
        public async Task<GymAdminMaster>GetGymAdminMaster(string username,string password)
        {
            return await _Context.GymAdminMaster.Where(s => s.UserName == username && s.Password == password).FirstOrDefaultAsync();
        }
    }
}
