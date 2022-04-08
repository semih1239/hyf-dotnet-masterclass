using MealsharingNet.models;

namespace MealsharingNet;

public interface IReservationRepository
{
    IEnumerable<Reservation> ListReservations();
    void AddReservation(Reservation reservation);
    List<Reservation> GetMealReservations(int mealId);

}