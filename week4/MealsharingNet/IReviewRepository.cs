using MealsharingNet.Models;

namespace MealsharingNet;

public interface IReviewRepository
{
    IEnumerable<Review> ListReviews();
    void AddReview(Review review);
    List<Review> GetMealReviews(int mealId);

}