namespace eCinemaTickets.Controllers
{
    using eCinemaTickets.Data;
    using eCinemaTickets.Data.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class ActorsController : Controller
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService)
            => this._actorService = actorService;

        public async Task<IActionResult> Index()
        {
            var allActors = await _actorService.GetAll();

            return View(allActors);
        }

        public IActionResult Create()
            => View();
    }
}
