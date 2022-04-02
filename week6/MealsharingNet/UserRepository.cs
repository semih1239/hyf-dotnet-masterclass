using MySql.Data.MySqlClient;
using Dapper;

namespace MealsharingNet;

public class UserRepository : IUserRepository
{
    private readonly MySqlConnection _connection;
    public UserRepository()
    {
        _connection = new MySqlConnection(Shared.ConnectionString);
    }

    public async Task AddUser(User user)
    {
        await _connection.ExecuteAsync("insert into users values (@ID, @Name, @Email, @Phone)", user);
    }

    public async Task DeleteUserById(int id)
    {
        await _connection.ExecuteAsync(@"delete from users where id = @id", new { id = id });
    }

    public async Task<User> GetUserByID(int id)
    {
        var user = await _connection.QueryFirstAsync<User>("select * from users where id=@id", new { id = id });
        return user;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        var users = await _connection.QueryAsync<User>("select * from users");
        return users;
    }
}