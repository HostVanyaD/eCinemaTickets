namespace eCinemaTickets.Controllers
{
    using eCinemaTickets.Data.Services;
    using eCinemaTickets.Models;
    using eCinemaTickets.ViewModels.Actor;
    using Microsoft.AspNetCore.Mvc;

    public class ActorsController : Controller
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService)
            => this._actorService = actorService;

        public async Task<IActionResult> Index()
        {
            var allActors = await _actorService.GetAllAsync();

            return View(allActors);
        }

        public IActionResult Create()
            => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateActorFormModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            var newActor = new Actor
            {
                ProfilePictureURL = actor.ProfilePictureURL,
                FullName = actor.FullName,
                Bio = actor.Bio
            };

           await  _actorService.AddAsync(newActor);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var actor = await _actorService.GetByIdAsync(id);

            if (actor == null)
            {
                return View("Not Found");
            }

            return View(actor);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _actorService.DeleteAsync(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _actorService
                .GetByIdAsync(id);

            if (actor == null)
            {
                return View("Not Found");
            }

            return View(actor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            await _actorService.UpdateAsync(id, actor);

            return RedirectToAction("Index");
        }
    }
}
