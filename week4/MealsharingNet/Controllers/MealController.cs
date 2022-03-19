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
        return _repo.ListMeal();
    }

    [HttpPost("AddMeal")]
    public void AddMeal([FromBody] Meal meal)
    {
        _repo.AddMeal(meal);
    }

    [HttpGet("Get Meal with ID")]
    public Meal GetMeal(int id)
    {
        return _repo.GetMeal(id);
    }
}