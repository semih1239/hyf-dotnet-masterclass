using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNet;
using MealsharingNet.models;

public class ReservationRepository : IReservationRepository
{
    private MySqlConnection _connection;
    public ReservationRepository()
    {
        _connection = new MySqlConnection(Shared.ConnectionString);
    }
    public async Task AddReservation(Reservation reservation)
    {
        await _connection.ExecuteAsync("insert into reservations values (@ID, @number_of_guests, @Meal_ID, @created_date, @contact_phonenumber, @contact_name, @contact_email)", reservation);
    }

    public async Task DeleteReservation(int id)
    {
        await _connection.ExecuteAsync(@"DELETE FROM reservations WHERE Id = @Id", new { Id = id });
    }

    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        var meal = await _connection.QueryAsync<Reservation>("select * from reservations where meal_id=@mealId", new { mealId = id });
        return meal.ToList();
    }

    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        var meals = await _connection.QueryAsync<Reservation>("select * from reservations");
        return meals;
    }

    public async Task UpdateReservation(Reservation reservation)
    {
        await _connection.ExecuteAsync("UPDATE reservations SET id=@ID, meal_id=@Meal_ID, contact_name=@contact_name, contact_email=@contact_email, number_of_guests=@number_of_guests, created_date=@created_date,contact_phonenumber=@contact_phonenumber WHERE id = @ID", reservation);
    }
}