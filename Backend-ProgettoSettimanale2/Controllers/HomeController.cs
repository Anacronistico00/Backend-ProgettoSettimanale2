using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Backend_ProgettoSettimanale2.Models;
using static System.Net.WebRequestMethods;

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
                    Url = "https://i8.amplience.net/i/jpl/jd_027536_b?qlt=92&w=750&h=531&v=1&fmt=auto"
                },
                new Immagine()
                {
                    Url = "https://i8.amplience.net/i/jpl/jd_027536_a?qlt=92&w=750&h=531&v=1&fmt=auto"
                },
                new Immagine()
                {
                    Url = "https://i8.amplience.net/i/jpl/jd_027536_e?qlt=92&w=750&h=531&v=1&fmt=auto"
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
            UrlCopertina = "https://photos6.spartoo.it/photos/188/18898615/adidas-Originals-SUPERSTAR-J-18898615_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/188/18898615/18898615_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/188/18898615/18898615_1200_D.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/188/18898615/18898615_1200_E.jpg"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Vans",
            Modello = "Old Skool",
            Prezzo = 80,
            Descrizione = "Le Vans Old Skool sono un modello di scarpe da skate prodotto dalla casa californiana Vans. Il modello è caratterizzato dalla banda laterale e dalla suola molto alta.",
            UrlCopertina = "https://photos6.spartoo.it/photos/261/26185/26185_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/261/26185/26185_1200_E.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/261/26185/26185_1200_F.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/261/26185/26185_1200_B.jpg"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Nike",
            Modello = "Air Jordan 1",
            Prezzo = 100,
            Descrizione = "Le Nike Air Jordan 1 sono un modello di scarpe da basket prodotto dalla casa americana Nike a partire dal 1985. Il modello è caratterizzato dalla suola in gomma e dalla chiusura con lacci.",
            UrlCopertina = "https://photos6.spartoo.it/photos/282/28262580/Nike-Air-Jordan-1-Mid-28262580_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/282/28262580/28262580_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/282/28262580/28262580_1200_D.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/282/28262580/28262580_1200_E.jpg"
                },

            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Adidas",
            Modello = "Grand Court 2.0",
            Prezzo = 90,
            Descrizione = "Le scarpe Adidas Superstar sono un modello di sneaker prodotto dalla casa tedesca Adidas a partire dal 1969. Il modello è caratterizzato dalla punta in gomma e dalle tre strisce laterali dello stesso materiale che decorano il lato esterno di ciascuna scarpa.",
            UrlCopertina = "https://photos6.spartoo.it/photos/246/24675503/24675503_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/246/24675503/24675503_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/246/24675503/24675503_1200_D.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/246/24675503/24675503_1200_E.jpg"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Vans",
            Modello = "Old Skool",
            Prezzo = 80,
            Descrizione = "Le Vans Old Skool sono un modello di scarpe da skate prodotto dalla casa californiana Vans. Il modello è caratterizzato dalla banda laterale e dalla suola molto alta.",
            UrlCopertina = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_E.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_F.jpg"
                }
            }
        },
        new Scarpa()
        { 
            Id = Guid.NewGuid(), 
            Marca = "Asics", 
            Modello = "GEL-VENTURE 10 WP", 
            Prezzo = 100,
            Descrizione = "Le Asics GEL-VENTURE 10 WP sono l'ideale per il running e il trekking. Divertiti all'aria aperta senza pensare al piede dolorante!",
            UrlCopertina = "https://photos6.spartoo.it/photos/284/28409429/28409429_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/284/28409429/28409429_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/284/28409429/28409429_1200_C.jpg"
                },                
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/284/28409429/28409429_1200_F.jpg"
                },

            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Nike",
            Modello = "Air Jordan 1 Low",
            Prezzo = 100,
            Descrizione = "Le Nike Air Jordan 1 sono un modello di scarpe da basket prodotto dalla casa americana Nike a partire dal 1985. Il modello è caratterizzato dalla suola in gomma e dalla chiusura con lacci.",
            UrlCopertina = "https://photos6.spartoo.it/photos/283/28380547/28380547_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/283/28380547/28380547_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/283/28327228/Nike---Air-jordan-1-low-bco-celeste-DC0774-164-28327228_1200_A.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/283/28380547/28380547_1200_D.jpg"
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
            UrlCopertina = "https://photos6.spartoo.it/photos/188/18898614/adidas-Originals-SUPERSTAR-J-18898614_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/188/18898614/18898614_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/188/18898614/18898614_1200_D.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/188/18898614/18898614_1200_F.jpg"
                }
            }
        },
        new Scarpa()
        { 
            Id = Guid.NewGuid(), 
            Marca = "Vans", 
            Modello = "Classic Slip-On", 
            Prezzo = 80,
            Descrizione = "Le Vans Classic Slip-On sono un modello di scarpe da skate prodotto dalla casa californiana Vans. Il modello è caratterizzato dalla banda laterale e dalla suola molto alta.",
            UrlCopertina = "https://photos6.spartoo.it/photos/218/218237/Vans-Classic-Slip-On-KIDS-218237_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/218/218237/218237_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/218/218237/218237_1200_D.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/218/218237/218237_1200_F.jpg"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "Vans",
            Modello = "Old Skool KIDS",
            Prezzo = 80,
            Descrizione = "Le Vans Old Skool sono un modello di scarpe da skate prodotto dalla casa californiana Vans. Il modello è caratterizzato dalla banda laterale e dalla suola molto alta.",
            UrlCopertina = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_E.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/780/7800601/7800601_1200_F.jpg"
                }
            }
        },
        new Scarpa()
        {
            Id = Guid.NewGuid(),
            Marca = "GLOBE",
            Modello = "Tilt/Marine",
            Prezzo = 90,
            Descrizione = "Le scarpe GLOBE Tilt/Marine sono perfette per le lunghe sedute di skating! La loro suola in gel permette un grip perfetto sulla tavola. Super leggere e comode! Non sentirai il minimo dislivello!",
            UrlCopertina = "https://photos6.spartoo.it/photos/273/27372665/Globe-Tilt-27372665_1200_A.jpg",
            Immagini = new List<Immagine>
            {
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/273/27372665/27372665_1200_B.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/273/27372665/27372665_1200_D.jpg"
                },
                new Immagine()
                {
                    Url = "https://photos6.spartoo.it/photos/273/27372665/27372665_1200_F.jpg"
                }
            }
        },

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
            return RedirectToAction("All");
        }

        var scarpaDetails = new ScarpaDetails
        {
            Id = scarpa.Id,
            Marca = scarpa.Marca,
            Modello = scarpa.Modello,
            Prezzo = scarpa.Prezzo,
            Descrizione = scarpa.Descrizione,
            UrlCopertina = scarpa.UrlCopertina,
            Immagini = scarpa.Immagini
        };


        return View(scarpaDetails);
    }

    public IActionResult Add()
    {
        var scarpaAddModel = new ScarpaAddModel();
        return View(scarpaAddModel);
    }

    [HttpPost]
    public IActionResult NewProdotto(ScarpaAddModel scarpaAddModel)
    {
        var newScarpa = new Scarpa
        {
            Id = Guid.NewGuid(),
            Marca = scarpaAddModel.Marca,
            Modello = scarpaAddModel.Modello,
            Prezzo = scarpaAddModel.Prezzo,
            Descrizione = scarpaAddModel.Descrizione,
            UrlCopertina = scarpaAddModel.UrlCopertina,
            InputUrl = scarpaAddModel.InputUrl,
            Immagini = new List<Immagine>()
        };

        if (!string.IsNullOrEmpty(scarpaAddModel.InputUrl))
        {
            var urls = scarpaAddModel.InputUrl
                .Split(',')
                .Select(url => url.Trim())
                .ToList();

            newScarpa.Immagini = urls.Select(url => new Immagine { Url = url }).ToList();
        }

        scarpe.Add(newScarpa);
        return RedirectToAction("All");
    }

    [HttpGet("home/prodotto/edit/{id:guid}")]
    public IActionResult Edit(Guid id)
    {
        var scarpa = scarpe.FirstOrDefault(s => s.Id == id);
        if (scarpa == null)
        {
            TempData["Error"] = "Prodotto non trovato!";
            return RedirectToAction("All");
        }

        var editProduct = new ModificaProdotto
        {
            Id = scarpa.Id,
            Marca = scarpa.Marca,
            Modello = scarpa.Modello,
            Prezzo = scarpa.Prezzo,
            Descrizione = scarpa.Descrizione,
            UrlCopertina = scarpa.UrlCopertina,
            InputUrl = string.Join(", ", scarpa.Immagini.Select(i => i.Url))
        };
        return View(editProduct);
    }

    [HttpPost("home/prodotto/edit/save/{id:guid}")]
    public IActionResult SaveEdit(Guid id, ModificaProdotto modificaProdotto)
    {
        var scarpa = scarpe.FirstOrDefault(s => s.Id == id);
        if (scarpa == null)
        {
            TempData["Error"] = "Prodotto non trovato!";
            return RedirectToAction("All");
        }
        scarpa.Marca = modificaProdotto.Marca;
        scarpa.Modello = modificaProdotto.Modello;
        scarpa.Prezzo = modificaProdotto.Prezzo;
        scarpa.Descrizione = modificaProdotto.Descrizione;
        scarpa.UrlCopertina = modificaProdotto.UrlCopertina;
        if (!string.IsNullOrEmpty(modificaProdotto.InputUrl))
        {
            var urls = modificaProdotto.InputUrl
                .Split(',')
                .Select(url => url.Trim())
                .ToList();
            scarpa.Immagini = urls.Select(url => new Immagine { Url = url }).ToList();
        }
        return RedirectToAction("All");
    }

    [HttpGet("home/prodotto/delete/{id:guid}")]
    public IActionResult Delete(Guid id) 
    {
        var scarpa = scarpe.FirstOrDefault(s => s.Id == id);
        if (scarpa == null)
        {
            TempData["Error"] = "Prodotto non trovato!";
            return RedirectToAction("Index");
        }
        var removed = scarpe.Remove(scarpa);

        if(!removed)
        {
            TempData["Error"] = "Errore nell'eliminazione del prodotto!";
            return RedirectToAction("Index");
        }
        return RedirectToAction("All");
    }

    public IActionResult All()
    {
        ScarpeViewModel scarpeList = new ScarpeViewModel
        {
            Scarpe = scarpe
        };
        return View(scarpeList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
