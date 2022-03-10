using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend!";}

    [Route("/")]
    public ActionResult Story()
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.Recipient = "Lina";
      myStoryVariable.Sender = "Jasmine";
      return View(myStoryVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/userStory")]
    public ActionResult UserStory(string user, string adj1, string adj2, string verb1, string town)
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.User = user;
      myStoryVariable.Adj1 = adj1;
      myStoryVariable.Adj2 = adj2;
      myStoryVariable.Verb1 = verb1;
      myStoryVariable.Town = town;
      return View(myStoryVariable);
    }

  }
}