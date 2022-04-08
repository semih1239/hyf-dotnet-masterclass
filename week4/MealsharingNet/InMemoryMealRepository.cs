using MealsharingNet;
using MealsharingNet.models;
using Microsoft.AspNetCore.Mvc;

namespace NewMealRepository;

public class InMemoryMealRepository : IMealRepository
{
    private static List<Meal> Meals { get; set; } = new List<Meal>()
    {
        new Meal(){ ID = 1, Title="Pasta", Description="Delicious Italian Pasta", Location="Copenhagen", MaxReservation=10, Price=150, ImageUrl="https://i2.milimaj.com/i/milliyet/75/0x410/5f15bc8a55428412e03417c6.jpg"},
        new Meal(){ ID = 2, Title="Pizza", Description="Homemade Pizza", Location="Hoje-Taastrup", MaxReservation=4, Price=200, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Supreme_pizza.jpg/1200px-Supreme_pizza.jpg"},
        new Meal(){ ID = 3, Title="Manti", Description="Amazing Turkish Manti", Location="Soro", MaxReservation=8, Price=250, ImageUrl="https://turkishfoodie.com/wp-content/uploads/2018/07/Kayseri-Mant%C4%B1s%C4%B1.jpg" }
    };
    public void AddMeal(Meal meal)
    {
        Meals.Add(meal);
    }

    public Meal GetMeal(int id)
    {
        var meal = Meals.FirstOrDefault(meal => meal.ID == id);
        return meal;
    }

    public IEnumerable<Meal> ListMeals()
    {
        return Meals;
    }
}