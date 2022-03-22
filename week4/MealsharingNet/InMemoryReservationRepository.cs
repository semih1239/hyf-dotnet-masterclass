using MealsharingNet;
using MealsharingNet.models;

namespace NewReservationRepository;

public class InMemoryReservationRepository : IReservationRepository
{
    private static List<Reservation> Reservations { get; set; } = new List<Reservation>()
    {
        new Reservation(){ ID = 1, MealID=2, Name="Semih Ayyildiz", Email="semihayyildiz23@outlook.com", NumberOfGuest=5, Date=new DateTime(2022, 7, 23, 08, 20, 10), PhoneNumber=11111111},
        new Reservation(){ ID = 2, MealID=3, Name="User", Email="user@outlook.com", NumberOfGuest=3, Date=new DateTime(2022, 7, 21, 08, 20, 10), PhoneNumber=22222222},
        new Reservation(){ ID = 3, MealID=3, Name="User 2", Email="user2@outlook.com", NumberOfGuest=7, Date=new DateTime(2022, 7, 11, 08, 20, 10), PhoneNumber=22222222},
        new Reservation(){ ID = 4, MealID=1, Name="User 3", Email="user3@outlook.com", NumberOfGuest=4, Date=new DateTime(2022, 7, 16, 08, 20, 10), PhoneNumber=3333333}
    };

    public void AddReservation(Reservation reservation)
    {
        Reservations.Add(reservation);
    }

    public List<Reservation> GetMealReservations(int id)
    {
        return Reservations.Where(_=>_.MealID == id).ToList();
    }

    public IEnumerable<Reservation> ListReservations()
    {
        return Reservations;
    }
}