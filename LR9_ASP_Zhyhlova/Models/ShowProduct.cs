using Microsoft.AspNetCore.Mvc;
using LR9_ASP_Zhyhlova.Models;

namespace LR9_ASP_Zhyhlova.Views.Home.Components
{
    public class ShowProduct : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            IEnumerable<Product> pizzas_list = new List<Product> {
                new Product(1, "Цезаре", 159),
                new Product(2, "Баварська", 159),
                new Product(3, "Маргарита", 139),
                new Product(4, "Карбонара", 169),
                new Product(5, "Палермо", 169)
            };

            return View(pizzas_list);
        }
    }
}
