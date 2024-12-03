using System.Diagnostics;

namespace _002_DelegateAsParameter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//WITHOUT PARAMETER IS CORRECT TO USE ANONYMOUS FUNCTION
			var printVariabile1 = () => { return "VAR 1"; };
			Console.WriteLine(printVariabile1());
			Console.WriteLine(printVariabile1);
			// > System.Func`1[System.String]
			//THE FOLLOW STATEMENT GIVE A COMPILER ERROR, CANNOT RECOGNIZE THE CORRECT DELEGATE TO USE
			//var printVariabile2 = (x) => { return "VAR 1" + x; };
			//YOU CAN CREATE YOU OWN DELEGATE OR USE A PRE-DEFINED DELEGATE LIKE ACTION OR FUNC
			Func<string, string> printVariabile3 = (x) => { return "VAR 1" + x; };
			Console.WriteLine(printVariabile3("!"));
			Console.WriteLine(printVariabile3);

			Func<string, string, string> printVariabile4 = (name, surname) => { return $"GREETINGS: {name} {surname}"; };
			Console.WriteLine(printVariabile4("phill", "baddys"));
			Console.WriteLine(printVariabile4);

			Func<Person, string> printVariabile5 = (p) => { return $"GREETINGS: {p.Name} {p.Surname}"; };
			Console.WriteLine(printVariabile5(Person.Init(x =>
			{
				x.Name = "A";
				x.Surname = "B";
			})));
			Console.WriteLine(printVariabile5);



			TestClass test = new TestClass();

			//DEFINING OBJECT




			Debug.WriteLine("");

		}
	}
}
