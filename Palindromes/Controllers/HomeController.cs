using Microsoft.AspNetCore.Mvc;
using Palindromes.Models;

namespace Palindromes.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult StartPage() { return View(); }

    [Route("/result")]
    public ActionResult Result() 
    { 
      return View(); 
    }
  }
}