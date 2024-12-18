namespace _002_DelegateAsParameter
{
	internal class ActionDemoClass
	{
		public ActionDemoClass()
		{
			ShowMessage();
			//USE ACTION TO REFER TO METHOD WITHOUT PARAMETER
			Action x_blank = ShowMessage;
			x_blank();
			//USE ACTION<T> TO REFER TO METHOD WITH ONE PARAMETER (string)
			Action<string> x = ShowMessage;
			x("1");
			//USE LAMBA EXPRESSION FOR DEFINING INLINE METHOD
			Action<string> y = (x) => { Console.WriteLine($"Hello world {x}"); };
			y("2");
			//In this case I pass a method inside another method.
			//In the second method I can use normally the first method the I've passed it
			PassDelegateThroughMethod(x);
		}

		private void PassDelegateThroughMethod(Action<string> x)
		{
			x("Gretings, inside a methos");
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