using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNet;
using MealsharingNet.models;

public class ReservationRepository : IReservationRepository
{
    public async Task AddReservation(Reservation reservation)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("insert into reservations values (@ID, @number_of_guests, @meal_id, @created_date, @contact_phonenumber, @contact_name, @contact_email)", reservation);
    }
    
    public async Task DeleteReservation(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync(@"DELETE FROM reservations WHERE Id = @Id", new { Id = id });
    }

    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryAsync<Reservation>("select * from reservations where meal_id=@mealId", new { mealId = id} );
        return meal.ToList();
    }

    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Reservation>("select * from reservations");
        return meals;
    }
    
    public async Task UpdateReservation(Reservation reservation)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE reservations SET id=@id, meal_id=@meal_id, contact_name=@contact_name, contact_email=@contact_email, number_of_guests=@number_of_guests, created_date=@created_date,contact_phonenumber=@contact_phonenumber WHERE id = @id", reservation);
    }
}