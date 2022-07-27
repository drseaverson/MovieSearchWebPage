using Microsoft.AspNetCore.Mvc;
using Movie_Search_Tool.Pages;

namespace Movie_Search_Tool.Controllers
{
	public class HomeController : Controller
	{
		[HttpPost]
		public IActionResult Index(IndexModel indexModel)
		{
			//indexModel.userInput = Request.Form["userInput"];
			System.Diagnostics.Debug.WriteLine("User Input Received: " + indexModel.userInput.ToString());
			return View(indexModel);
		}
	}
}
