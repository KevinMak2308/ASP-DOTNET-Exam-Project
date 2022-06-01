using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // HelloWorld Class - Index(Default) Action
        //IActionResult returns an action rather than a value type as we know from Java
        //The return statement does not specify what view to return, so it goes to the ->
        // <- default view matching the action method 'Index'.
        public IActionResult Index()
        {
            return View();
        }

        // HelloWorld Class - Welcome Action
        // = 1 after the variable value means that the parameter default for the value 'number' is 1.
        //HtmlEncoder protects the app for malicious input. 
        //Query String //
        // ? is a seperator of action and parameter in a query string
        // name and number values are passed in the query string, and the value is set using =
        // & is a seperates field value pairs ie. name= & ID=
        //A paramater ID is used before the query string: /{id}?name=
        //ViewData is a dynamic object which can pass parameter properties with an Action.

        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;
            
            return View();
        }
    }
}