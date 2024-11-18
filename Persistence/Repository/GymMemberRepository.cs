using Domain.Entities;
using Domain.Interface;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class GymMemberRepository : IGymMemberRepository
    {
        private readonly DataContext _context;
        public GymMemberRepository(DataContext dataContext) 
        {

            _context = dataContext;
        }
        public async Task<bool> AddGymMember(GymMember gymMember)
        {
            var result = await _context.GymMember.AddAsync(gymMember);
            var res = await _context.SaveChangesAsync();
            return res > 0;
        }
    }
}
