using MealsharingNet.models;

namespace MealsharingNet;

public interface IReservationRepository
{
    IEnumerable<Reservation> ListReservation();
    void AddReservation(Reservation reservation);
    List<Reservation> GetMealReservations(int mealId);

}