using System.Diagnostics;
using IcyMovies.Data;
using Microsoft.AspNetCore.Mvc;
using IcyMovies.Models;
using IcyMovies.Models.Viewmodels;
using Microsoft.EntityFrameworkCore;

namespace IcyMovies.Controllers;

public class HomeController : Controller
{
    private readonly IcyMoviesContext _context;
    public HomeController(IcyMoviesContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> HomeGenreHorizontalListPartial(List<Movie> vm)
    {
        /*HomePageVM vm = new HomePageVM();
        vm.HeroMovies = await _context.Movies.OrderBy(en => new Guid()).Take(2).ToListAsync();
        vm.AllMovies = await _context.Movies.ToListAsync();*/
        
        return PartialView("_HomeGenreHorizontalListPartial", vm);
    }
    public async Task<IActionResult> Index()
    {
        HomePageVM vm = new HomePageVM();
        vm.HeroMovies = await _context.Movies.OrderBy(en => new Guid()).Take(2).ToListAsync();
        vm.AllMovies = await _context.Movies.ToListAsync();
        
        return View(vm);
    }
    
    public IActionResult Movies()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}