using MealsharingNet.Models;
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
    public async Task<IEnumerable<Review>> ListReviews()
    {
        return await _repo.ListReviews();
    }

    [HttpPost("AddReview")]
    public async Task AddReview([FromBody] Review review)
    {
        await _repo.AddReview(review);
    }

    [HttpGet("GetMealReviewsWithID")]
    public async Task <List<Review>> GetMealReviews(int id)
    {
        return await _repo.GetMealReviews(id);
    }
    [HttpDelete("DeleteReview")]
    public async Task DeleteReview(int id)
    {
        await _repo.DeleteReview(id);
    }
    [HttpPatch("UpdateReview")]
    public async Task UpdateReview([FromBody] Review review)
    {
        await _repo.UpdateReview(review);
    }
}