using MealsharingNet;
using MealsharingNet.models;

namespace NewReviewRepository;

public class InMemoryReviewRepository : IReviewRepository
{
    private static List<Review> Reviews { get; set; } = new List<Review>()
    {
        new Review(){ ID = 1, title="Amazing", description="Best food ever", MealID=1, stars=5},
        new Review(){ ID = 2, title="Good", description="Food was good", MealID=2, stars=4},
        new Review(){ ID = 3, title="Bad", description="Food was very bad", MealID=3, stars=1},
        new Review(){ ID = 4, title="Okay", description="Normal taste", MealID=3, stars=3}
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