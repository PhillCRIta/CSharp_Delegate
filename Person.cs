using System.Diagnostics;

namespace _002_DelegateAsParameter
{
	class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public readonly string PredefinedVariable;
		public Person()
		{
			PredefinedVariable = "xxx";
		}

		public static Person Init(Action<Person> options)
		{
			Person person = new Person();
			//WHEN CALL options DELEGATE, I PASS THE PERSON OBJECT TO THE CALLER AND VIA LAMBDA EXPRESSION SETS ITS PROPERTIES
			options(person);
			return person;
		}
	}

}