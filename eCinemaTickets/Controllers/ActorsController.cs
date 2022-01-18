﻿namespace eCinemaTickets.Controllers
{
    using eCinemaTickets.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _context.Actors.ToListAsync();

            return View(allActors);
        }
    }
}
