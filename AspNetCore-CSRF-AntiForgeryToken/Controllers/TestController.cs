using AspNetCore_CSRF_AntiForgeryToken.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCore_CSRF_AntiForgeryToken.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TestViewModel viewModel)
        {
            // Your code here!

            return await Task.Run(() => View());
        }
    }
}