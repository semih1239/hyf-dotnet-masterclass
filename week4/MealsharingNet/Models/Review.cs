namespace MealsharingNet.Models;

public class Review
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int MealID { get; set; }
    public int Stars { get; set; }
}