namespace MealsharingNet.models;

public class Reservation
{
    public int ID { get; set; }
    public int Meal_ID { get; set; }
    public string Contact_Name { get; set; }
    public string Contact_Email { get; set; }
    public int Number_Of_Guests { get; set; }
    public DateTime Created_Date { get; set; }
    public string Contact_PhoneNumber { get; set; }
}