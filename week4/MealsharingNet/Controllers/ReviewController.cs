using MealsharingNet.models;
using Microsoft.AspNetCore.Mvc;

namespace MealsharingNet.Controllers;

[ApiController]
[Route("Reviews")]
public class ReviewController : ControllerBase
{
    private IReviewRepository _repo;

    public ReviewController(IReviewRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("GetReviews")]
    public IEnumerable<Review> ListReviews()
    {
        return _repo.ListReviews();
    }

    [HttpPost("AddReview")]
    public void AddReview([FromBody] Review review)
    {
        _repo.AddReview(review);
    }

    [HttpGet("GetMealReviewsWithID")]
    public List<Review> GetMealReviews(int id)
    {
        return _repo.GetMealReviews(id);
    }
}