using DataAccess.Entities.Users;

namespace DataAccess.Repositories.UserRepository;

public interface IUsersRepository
{
    public IEnumerable<UserEntity> GetUsers();
}