using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      string emptyField = "";
      return View("Index", emptyField);
    }

    [HttpPost("/result")]
    public ActionResult Result()
    {
      string findWord = Request.Form["find-word"];
      string inputPhrase = Request.Form["input-phrase"];
      WordCount newWordCount = new WordCount(inputPhrase, findWord);
      int displayCount = newWordCount.RepeatCounter();
      return View("Index", displayCount);
    }
  }
}
