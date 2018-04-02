using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ControllersAndActions.Controllers
{
    public class PocoController : Controller
    {
        public ViewResult Index() =>
            View("Result", $"This is a derived controller");
    }
}