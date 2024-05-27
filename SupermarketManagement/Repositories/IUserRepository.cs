using SupermarketManagement.Models;

namespace SupermarketManagement.Repositories
{
    public interface IUserRepository
    {
        UserModel GetUserByEmail(string email);
    }
}