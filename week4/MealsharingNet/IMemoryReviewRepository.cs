using MealsharingNet;
using MealsharingNet.Models;

namespace NewReviewRepository;

public class InMemoryReviewRepository : IReviewRepository
{
    private static List<Review> Reviews { get; set; } = new List<Review>()
    {
        new Review(){ ID = 1, Title="Amazing", Description="Best food ever", MealID=1, Stars=5},
        new Review(){ ID = 2, Title="Good", Description="Food was good", MealID=2, Stars=4},
        new Review(){ ID = 3, Title="Bad", Description="Food was very bad", MealID=3, Stars=1},
        new Review(){ ID = 4, Title="Okay", Description="Normal taste", MealID=3, Stars=3}
    };

    public void AddReview(Review review)
    {
        Reviews.Add(review);
    }

    public List<Review> GetMealReviews(int id)
    {
        var reviews = new List<Review>();
        foreach (var rev in Reviews)
        {
            if (rev.MealID == id) reviews.Add(rev);
        }
        return reviews;
    }

    public IEnumerable<Review> ListReviews()
    {
        return Reviews;
    }
}