using Microsoft.AspNetCore.Mvc.Rendering;
using MyShop.Models;

namespace MyShop.ViewModels
{
    public class CreateOrderItemViewModel
    {
        public OrderItem OrderItem { get; set; } = default!;
        public List<SelectListItem> ItemSelectedList { get; set; } = default!;
        public List<SelectListItem> OrderSelectList { get; set; } = default!;
    }
}
