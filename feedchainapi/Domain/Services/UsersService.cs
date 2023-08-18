using feedchainapi.Domain.IServices;
using feedchainapi.Models;

namespace feedchainapi.Domain.Services
{
    public class UsersService : IUsersService
    {
        private readonly IConfiguration _configuration;
        public UsersService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<Users> DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> RegisterUser(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<Users> UpdateUser(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
