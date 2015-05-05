using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Demo.Javascript.Template.Hogan.Models;

namespace Demo.Javascript.Template.Hogan.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult People()
		{
			List<Person> people = GetPeople();
			var peopleList = people.Select(person => new
			{
				FirstName = person.FirstName,
				LastName = person.LastName,
				FullName = string.Format("{0}, {1}", person.LastName, person.FirstName)
			});
			//string json = new JavaScriptSerializer().Serialize(peopleList);
			//return View((object)json);
			return View(people);
		}

		private List<Person> GetPeople()
		{
			return new List<Person>
				{
					new Person("John", "Doe"),
					new Person("Jane", "Doe"),
					new Person("Robert", "Smith"),
					new Person("Mike", "Durden"),
					new Person("Marilin", "Monroe"),
				};
		}
	}
}