namespace MealsharingNet.models;

public class Meal
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int MaxReservation { get; set; }
    public int Price { get; set; }
    public string ImageUrl { get; set; }
}