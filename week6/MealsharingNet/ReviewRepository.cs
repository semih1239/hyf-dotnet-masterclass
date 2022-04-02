using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNet;
using MealsharingNet.Models;

public class ReviewRepository : IReviewRepository
{
    private MySqlConnection _connection;
    public ReviewRepository()
    {
        _connection = new MySqlConnection(Shared.ConnectionString);
    }
    public async Task AddReview(Review review)
    {
        await _connection.ExecuteAsync("insert into reviews values (@ID, @title, @description, @Meal_ID, @stars, @created_date)", review);
    }
    public async Task<List<Review>> GetMealReviews(int id)
    {
        var review = await _connection.QueryAsync<Review>("select * from reviews where meal_id=@mealId", new { mealId = id });
        return review.ToList();
    }

    public async Task<IEnumerable<Review>> ListReviews()
    {
        var reviews = await _connection.QueryAsync<Review>("select * from reviews");
        return reviews;
    }
    public async Task UpdateReview(Review review)
    {
        await _connection.ExecuteAsync("UPDATE reviews SET id=@ID, title=@title, description=@description, meal_id=@Meal_ID, stars=@stars, created_date=@created_date WHERE id=@ID", review);
    }
    public async Task DeleteReview(int id)
    {
        await _connection.ExecuteAsync(@"DELETE FROM reviews WHERE Id = @Id", new { Id = id });
    }
}