using DataAccess.Entities.Users;

namespace DataAccess.Repositories.UserRepository;

public class UsersRepository : IUsersRepository
{
    public UsersRepository(string connectionString)
    {
        
    }
    
    public IEnumerable<UserEntity> GetUsers()
    {
        throw new NotImplementedException();
    }
}