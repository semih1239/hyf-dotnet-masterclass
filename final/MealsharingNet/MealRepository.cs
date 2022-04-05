using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNet;
using MealsharingNet.Models;

public class MealRepository : IMealRepository
{
    private MySqlConnection _connection;
    public MealRepository()
    {
        _connection = new MySqlConnection(Shared.ConnectionString);
    }
    public async Task AddMeal(Meal meal)
    {
        await _connection.ExecuteAsync("insert into meals values (@ID, @Title, @Description, @When, @Location, @Max_reservations, @Price, @Img_link, @created_date)", meal);
    }

    public async Task DeleteMeal(int id)
    {
        await _connection.ExecuteAsync(@"DELETE FROM meals WHERE Id = @Id", new { Id = id });
    }

    public async Task<Meal> GetMeal(int id)
    {
        var meal = await _connection.QueryFirstAsync<Meal>("select * from meals where id=@mealId", new { mealId = id });
        return meal;
    }

    public async Task<IEnumerable<Meal>> ListMeals()
    {
        var meals = await _connection.QueryAsync<Meal>("select * from meals");
        return meals;
    }

    public async Task UpdateMeal(Meal meal)
    {
        await _connection.ExecuteAsync("UPDATE meals SET title=@title, description=@description, location=@location, max_reservations=@max_reservations, price=@price, created_date=@created_date, img_link=@Img_link WHERE id = @ID", meal);
    }
}