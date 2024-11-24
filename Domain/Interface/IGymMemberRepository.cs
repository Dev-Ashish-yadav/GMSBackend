using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IGymMemberRepository
    {
        public Task<bool> AddGymMember(GymMember gymMember);
        public Task<int> UpdateMembers(GymMember gymMember);
        public Task<int> DeleteMembers(int id);
        public Task<List<GymMember>> GetAllMembersAsync();
        public Task<GymMember> GetMemberBasedOnIdAsync(int id);
    }
}
