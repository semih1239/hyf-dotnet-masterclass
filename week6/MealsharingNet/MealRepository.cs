using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNet;
using MealsharingNet.models;

public class MealRepository : IMealRepository
{
    public async Task AddMeal(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("insert into meals values (@ID, @Title, @Description, @When, @Location, @Max_reservations, @Price, @Img_link, @created_date)", meal);
    }

    public async Task DeleteMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync(@"DELETE FROM meals WHERE Id = @Id", new { Id = id });
    }

    public async Task<Meal> GetMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("select * from meals where id=@mealId", new { mealId = id} );
        return meal;
    }

    public async Task<IEnumerable<Meal>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meal>("select * from meals");
        return meals;
    }

    public async Task UpdateMeal(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE meals SET title=@title, description=@description, location=@location, max_reservations=@max_reservations, price=@price, created_date=@created_date,img_link=@img_link WHERE id = @id", meal);
    }
}