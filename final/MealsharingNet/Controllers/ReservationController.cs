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
    public async Task<IEnumerable<Reservation>> GetReservations()
    {
        return await _repo.ListReservations();
    }

    [HttpPost("AddReservation")]
    public async Task AddReservation([FromBody] Reservation reservation)
    {
        await _repo.AddReservation(reservation);
    }

    [HttpGet("GetMealReservationWithID")]
    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        return await _repo.GetMealReservations(id);
    }
    [HttpDelete("Deletereservation")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }
    [HttpPatch("UpdateReservation")]
    public async Task UpdateMeal([FromBody] Reservation reservation)
    {
        await _repo.UpdateReservation(reservation);
    }
}