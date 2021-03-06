using MealsharingNet.models;
using Microsoft.AspNetCore.Mvc;

namespace MealsharingNet.Controllers;

[ApiController]
[Route("Reservation")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("GetReservations")]
    public IEnumerable<Reservation> GetReservations()
    {
        return _repo.ListReservations();
    }

    [HttpPost("AddReservation")]
    public void AddReservation([FromBody] Reservation reservation)
    {
        _repo.AddReservation(reservation);
    }

    [HttpGet("GetMealReservationWithID")]
    public List<Reservation> GetMealReservations(int id)
    {
        return _repo.GetMealReservations(id);
    }
}