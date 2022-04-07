using Microsoft.AspNetCore.Mvc;
namespace Potfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
                public ViewResult Index()
        {
            ViewBag.myVariable = "This is a prop! pretty sure";
            return View("index");
        }
        [HttpGet]
        [Route("unitedStates")]
            public ViewResult Zoe()
        {
            return View("unitedStates");
        }
                [HttpGet]
        [Route("another")]
            public ViewResult Another()
        {
            return View("another");
        }
    }
}