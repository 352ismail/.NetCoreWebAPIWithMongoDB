using feedchainapi.Models;

namespace feedchainapi.Domain.IServices
{
    public interface IUsersService
    {
        public Task<Users> GetAll();
        public Task<Users> GetById(string id);
        public Task<Users> RegisterUser(Users users);
        public Task<Users> UpdateUser(Users users);
        public Task<Users> DeleteUser(string id);
    }
}
