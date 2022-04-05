using MealsharingNet.Models;

namespace MealsharingNet;

public interface IReservationRepository
{
    Task<IEnumerable<Reservation>> ListReservations();
    Task AddReservation(Reservation reservation);
    Task<List<Reservation>> GetMealReservations(int id);
    Task DeleteReservation(int id);
    Task UpdateReservation(Reservation reservation);
}