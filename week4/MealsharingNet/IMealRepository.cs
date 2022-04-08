using MealsharingNet.models;

namespace MealsharingNet;

public interface IMealRepository
{
    IEnumerable<Meal> ListMeals();
    void AddMeal(Meal meal);
    Meal GetMeal(int id);

}