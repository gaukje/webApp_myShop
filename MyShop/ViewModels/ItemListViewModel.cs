using MyShop.Models;

namespace MyShop.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items;
        public String? CurrentViewName;

        public ItemListViewModel(IEnumerable<Item> items, String? currentViewName)
        {
            Items = items;
            CurrentViewName = currentViewName;
        }
    }
}
