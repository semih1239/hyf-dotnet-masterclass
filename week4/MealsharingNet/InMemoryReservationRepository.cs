using MealsharingNet;
using MealsharingNet.models;

namespace NewReservationRepository;

public class InMemoryReservationRepository : IReservationRepository
{
    private static List<Reservation> Reservations { get; set; } = new List<Reservation>()
    {
        new Reservation(){ ID = 1, MealID=2, Name="Semih Ayyildiz", Email="semihayyildiz23@outlook.com", NumberOfGuest=5, PhoneNumber=11111111},
        new Reservation(){ ID = 2, MealID=3, Name="User", Email="user@outlook.com", NumberOfGuest=3, PhoneNumber=22222222},
        new Reservation(){ ID = 3, MealID=3, Name="User 2", Email="user2@outlook.com", NumberOfGuest=7, PhoneNumber=22222222},
        new Reservation(){ ID = 4, MealID=1, Name="User 3", Email="user3@outlook.com", NumberOfGuest=4, PhoneNumber=3333333}
    };

    public void AddReservation(Reservation reservation)
    {
        Reservations.Add(reservation);
    }

    public List<Reservation> GetMealReservations(int id)
    {
        var reservations = new List<Reservation>();
        foreach (var res in Reservations)
        {
            if (res.MealID == id) reservations.Add(res);
        }
        return reservations;
    }

    public IEnumerable<Reservation> ListReservation()
    {
        return Reservations;
    }
}