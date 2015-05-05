namespace Demo.Javascript.Template.Hogan.Models
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Person()
		{
		}

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
	}
}