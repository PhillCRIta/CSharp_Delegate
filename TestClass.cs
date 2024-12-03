namespace _002_DelegateAsParameter
{
	internal class TestClass
	{
		public TestClass()
		{
			//USE ACTION TO REFER TO METHOD WITHOUT PARAMETER
			Action x_blank = ShowMessage;
			x_blank();
			//USE ACTION<T> TO REFER TO METHOD WITH ONE PARAMETER (string)
			Action<string> x = ShowMessage;
			x("1");
			//USE LAMBA EXPRESSION FOR DEFINING INLINE METHOD
			Action<string> y = (x) => { Console.WriteLine($"Hello world {x}"); };
			y("2");
		}

		public void ShowMessage()
		{
			Console.WriteLine($"Hello world BLANK");
		}

		public void ShowMessage(string val)
		{
			Console.WriteLine($"Hello world {val}");
		}
	}
}