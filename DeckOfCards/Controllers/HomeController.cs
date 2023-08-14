using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DeckOfCards.Models;

namespace DeckOfCards.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Deck()
    {
        DeckOfCardsModel result = DeckOfCardsDAL.GetDeck();
        return View(result);
    }

    public IActionResult DrawFive(Card c)
    {
        DeckOfCardsModel result = DeckOfCardsDAL.GetDeck();
        return View(result);
    }

    public IActionResult ReshuffleDeck()
    {
        DeckOfCardsModel result = DeckOfCardsDAL.GetDeck();
        return View(result);
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

