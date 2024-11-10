using Domain.Entities;
using Domain.Interface;
using Persistence.Context;

namespace Persistence.Repository
{
    public class Gym_User_MasterRepository : IGym_User_MasterRepository
    {
        private readonly DataContext _dataContext;
        public Gym_User_MasterRepository( DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> AddMembers(Gym_Users_master gym_User_Master)
        {
            try
            {
                var result = await _dataContext.Gym_User_Master.AddAsync(gym_User_Master);
                _dataContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
