using MerkazApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace MerkazApp.Controllers
{
   
    public class BudgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            List<CategorieDepenseVM> CategoriesDepense = new List<CategorieDepenseVM>();
            CategoriesDepense.Add(new CategorieDepenseVM { CategorieDepenseID = 1,Titre= "Transport" });
            CategoriesDepense.Add(new CategorieDepenseVM { CategorieDepenseID = 2,Titre= "Loyer" });
            CategoriesDepense.Add(new CategorieDepenseVM { CategorieDepenseID = 3,Titre= "Loisir" });
            CategoriesDepense.Add(new CategorieDepenseVM { CategorieDepenseID = 4,Titre= "Categorie" });

            ViewBag.CategoriesDepense = CategoriesDepense;  


            List<DepenseVM> list = new List<DepenseVM>();
            list.Add(new DepenseVM(1, "Type", "Transport", "S/O", 500, "Mensuel"));
            list.Add(new DepenseVM(1, "Type", "Loyer", "S/O", 500, "Mensuel"));
            list.Add(new DepenseVM(1, "Type", "Loisir", "S/O", 500, "Mensuel"));
            list.Add(new DepenseVM(1, "Type", "Loyer", "S/O", 500, "Mensuel"));
            list.Add(new DepenseVM(1, "Type", "Transport", "S/O", 500, "Mensuel"));
            list.Add(new DepenseVM(1, "Type", "Categorie", "S/O", 500, "Mensuel"));

            return View(list);
        }

        public IActionResult Incomes()
        {
         
            return View();
        }

        [HttpGet]
        public IActionResult NewExpense()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewExpense(DepenseVM depense)
        {
            return RedirectToAction("Expenses");
        }

    }
}
