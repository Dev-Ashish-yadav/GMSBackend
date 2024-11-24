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

        //update GymMembers table
        public async Task<int> UpdateMembers(GymMember gymMember)
        {
            var result = await _context.GymMember.Where(s => s.Id == gymMember.Id).FirstOrDefaultAsync();
            if(result !=null)
            {

                result.AdharCard = gymMember.AdharCard;
                result.MedicalIssueDescription = gymMember.MedicalIssueDescription;
                result.MedicalIssue= gymMember.MedicalIssue;
                result.AdharCard =gymMember.AdharCard;
                result.Amount = gymMember.Amount;
                result.DateOfBirth = gymMember.DateOfBirth;
                result.DateOfBirth =gymMember.DateOfBirth;
                result.UpdatedDate = gymMember.UpdatedDate;
                result.Balance = gymMember.Balance;
                result.City = gymMember.City;
                result.Country = gymMember.Country;
                result.Phone = gymMember.Phone;
                result.ProfilePhoto = gymMember.ProfilePhoto;
                result.Email = gymMember.Email;
                result.FirstName = gymMember.FirstName;
                result.LastName = gymMember.LastName;
                result.Gender = gymMember.Gender;
                result.GymId = gymMember.Id;
                result.GymPlanID =gymMember.GymPlanID;
                result.PanCard = gymMember.PanCard;
                result.UpdatedDate =DateTime.Now;
                result.PostalCode = gymMember.PostalCode;
                result.Region = gymMember.Region;
                var res = await _context.SaveChangesAsync();
                return res;

            }
            return 0;
        }
        //delete GymMembers
        public async Task<int> DeleteMembers(int id)
        {
            var res = await _context.GymMember.FindAsync(id); 
            if (res != null)
            {
                _context.GymMember.Remove(res);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
        //return all members
        public async Task<List<GymMember>> GetAllMembersAsync()
        {
            return await _context.GymMember.ToListAsync(); // Fetches all GymMember records
        }
        //based on id member data
        public async Task<GymMember> GetMemberBasedOnIdAsync(int id)
        {
            return await _context.GymMember.FindAsync(id);
        }
    }
}
