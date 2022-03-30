using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNet;
using MealsharingNet.Models;

public class ReviewRepository : IReviewRepository
{
    public async Task AddReview(Review review)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("insert into reviews values (@ID, @title, @description, @meal_id, @stars, @created_date)", review);
    }
    public async Task<List<Review>> GetMealReviews(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var review = await connection.QueryAsync<Review>("select * from reviews where meal_id=@mealId", new { mealId = id} );
        return review.ToList();
    }

    public async Task<IEnumerable<Review>> ListReviews()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reviews = await connection.QueryAsync<Review>("select * from reviews");
        return reviews;
    }
    public async Task UpdateReview(Review review)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE reviews SET id=@id, title=@title, description=@description, meal_id=@meal_id, stars=@stars, created_date=@created_date WHERE id=@id", review);
    }
    public async Task DeleteReview(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync(@"DELETE FROM reviews WHERE Id = @Id", new { Id = id });
    }
}