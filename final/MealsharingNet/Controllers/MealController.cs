using MealsharingNet.models;
using Microsoft.AspNetCore.Mvc;

namespace MealsharingNet.Controllers;

[ApiController]
[Route("Meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("GetMeals")]
    public async Task<IEnumerable<Meal>> GetMeals()
    {
        return await _repo.ListMeals();
    }

    [HttpPost("AddMeal")]
    public async Task AddMeal([FromBody] Meal meal)
    {
        await _repo.AddMeal(meal);
    }

    [HttpGet("GetMealWithID")]
    public async Task <Meal> GetMeal(int id)
    {
        return await _repo.GetMeal(id);
    }
    [HttpDelete("DeleteMeal")]
    public async Task DeleteMeal(int id)
    {
        await _repo.DeleteMeal(id);
    }
    [HttpPatch("UpdateMeal")]
    public async Task UpdateMeal([FromBody] Meal meal)
    {
        await _repo.UpdateMeal(meal);
    }
}