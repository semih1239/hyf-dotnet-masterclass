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
    public IEnumerable<Meal> GetMeals()
    {
        return _repo.ListMeals();
    }

    [HttpPost("AddMeal")]
    public void AddMeal([FromBody] Meal meal)
    {
        _repo.AddMeal(meal);
    }

    [HttpGet("GetMealWithID")]
    public Meal GetMeal(int id)
    {
        return _repo.GetMeal(id);
    }
}