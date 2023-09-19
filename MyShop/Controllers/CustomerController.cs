using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;
using MyShop.DAL;

namespace MyShop.Controllers;

public class CustomerController : Controller
{
    private readonly IItemRepository _itemRepository;

    public CustomerController(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public async Task<IActionResult> Table()
    {
        var customer = await _itemRepository.GetAll(); 
        return View(customer);
    }
}
