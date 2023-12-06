using Microsoft.AspNetCore.Mvc;
using WarehouseManagementSystem.Infrastructure;

namespace WarehouseManagementSystem.Web.Controllers;

public class CustomerController(IRepository<Customer> customerRepository) : Controller
{
    private readonly IRepository<Customer> customerRepository = customerRepository;

    public IActionResult Index(Guid? id)
    {
        if (id == null)
        {
            var customers = customerRepository.All();

            return View(customers);
        }
        else
        {
            var customer = customerRepository.Get(id.Value);

            return View(new[] { customer });
        }
    }
}
