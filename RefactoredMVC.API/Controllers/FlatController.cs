using Microsoft.AspNetCore.Mvc;
using RefactoredMVC.Application.Interfaces;
using RefactoredMVC.Core.Models;

namespace RefactoredMVC.API.Controllers
{
    public class FlatController(IFlatService service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Flat> flats = await service.GetFullFlats(1, 20);

            return View(flats);
        }
    }
}
