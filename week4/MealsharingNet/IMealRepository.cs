using MealsharingNet.models;

namespace MealsharingNet;

public interface IMealRepository
{
    IEnumerable<Meal> ListMeal();
    void AddMeal(Meal meal);
    Meal GetMeal(int id);

}