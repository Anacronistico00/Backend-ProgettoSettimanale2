using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Backend_ProgettoSettimanale2.Models;

namespace Backend_ProgettoSettimanale2.Controllers;

public class HomeController : Controller
{
    private static List<Scarpa> scarpe = new List<Scarpa>
    {
        new Scarpa()
        { 
            Id = Guid.NewGuid(), 
            Marca = "Nike", 
            Modello = "Air Force 1", 
            Prezzo = 100,
            Descrizione = "Le Nike Air Force 1 sono un modello di scarpe da basket prodotto dalla casa americana Nike a partire dal 1982. Il modello è caratterizzato dalla suola in gomma e dalla chiusura con lacci.",
            UrlCopertina = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },                
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },

            }
        },
        new Scarpa()
        { 
            Id = Guid.NewGuid(), 
            Marca = "Adidas", 
            Modello = "Superstar", 
            Prezzo = 90,
            Descrizione = "Le scarpe Adidas Superstar sono un modello di sneaker prodotto dalla casa tedesca Adidas a partire dal 1969. Il modello è caratterizzato dalla punta in gomma e dalle tre strisce laterali dello stesso materiale che decorano il lato esterno di ciascuna scarpa.",
            UrlCopertina = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-3-white?$n_750w$&wid=750&hei=750&fit=crop"
                }
            }
        },
        new Scarpa()
        { 
            Id = Guid.NewGuid(), 
            Marca = "Vans", 
            Modello = "Old Skool", 
            Prezzo = 80,
            Descrizione = "Le Vans Old Skool sono un modello di scarpe da skate prodotto dalla casa californiana Vans. Il modello è caratterizzato dalla banda laterale e dalla",
            UrlCopertina = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Nike",
            Modello = "Air Force 1",
            Prezzo = 100,
            Descrizione = "Le Nike Air Force 1 sono un modello di scarpe da basket prodotto dalla casa americana Nike a partire dal 1982. Il modello è caratterizzato dalla suola in gomma e dalla chiusura con lacci.",
            UrlCopertina = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },

            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Adidas",
            Modello = "Superstar",
            Prezzo = 90,
            Descrizione = "Le scarpe Adidas Superstar sono un modello di sneaker prodotto dalla casa tedesca Adidas a partire dal 1969. Il modello è caratterizzato dalla punta in gomma e dalle tre strisce laterali dello stesso materiale che decorano il lato esterno di ciascuna scarpa.",
            UrlCopertina = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-3-white?$n_750w$&wid=750&hei=750&fit=crop"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Vans",
            Modello = "Old Skool",
            Prezzo = 80,
            Descrizione = "Le Vans Old Skool sono un modello di scarpe da skate prodotto dalla casa californiana Vans. Il modello è caratterizzato dalla banda laterale e dalla",
            UrlCopertina = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-1-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-2-white?$n_750w$&wid=750&hei=750&fit=crop"
                },
                new Immagine()
                {
                    Url = "https://images.asos-media.com/products/nike-air-force-1-07-sneakers-triplo-bianco/202389207-3-white?$n_750w$&wid=750&hei=750&fit=crop"
                }
            }
        }

    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ScarpeViewModel scarpeList = new ScarpeViewModel
        {
            Scarpe = scarpe
        };
        return View(scarpeList);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Prodotto(Guid id)
    {
        var scarpa = scarpe.FirstOrDefault(s => s.Id == id);
        if (scarpa == null)
        {
            TempData["Error"] = "Product not found!";
            return RedirectToAction("Index");
        }

        var scarpaDetails = new ScarpaDetails
        {
            Id = scarpa.Id,
            Marca = scarpa.Marca,
            Modello = scarpa.Modello,
            Prezzo = scarpa.Prezzo.ToString(),
            Descrizione = scarpa.Descrizione,
            UrlCopertina = scarpa.UrlCopertina,
            Immagini = scarpa.Immagini
        };

        return View(scarpaDetails);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
