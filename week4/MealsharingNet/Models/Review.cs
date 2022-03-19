namespace MealsharingNet.models;

public class Review
{
    public int ID { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int MealID { get; set; }
    public int stars { get; set; }
}