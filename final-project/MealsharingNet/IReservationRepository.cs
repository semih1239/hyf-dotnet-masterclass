using MealsharingNet.models;

namespace MealsharingNet;

public interface IReservationRepository
{
    Task <IEnumerable<Reservation>> ListReservations();
    Task AddReservation(Reservation reservation);
    Task <List<Reservation>> GetMealReservations(int mealId);
    Task DeleteReservation(int id);
    Task UpdateReservation(Reservation reservation);
}