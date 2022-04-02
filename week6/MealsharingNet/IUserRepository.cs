namespace MealsharingNet;

public interface IUserRepository
{
    Task<User> GetUserByID(int id);
    Task<IEnumerable<User>> GetUsers();
    Task DeleteUserById(int id);
    Task AddUser(User user);
}