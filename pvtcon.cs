//private constructor
using System;
class pvtcon
{
	pvtcon()
	{
			Console.WriteLine("hello private class.");
	}
	static void Main()
	{
		pvtcon d=new pvtcon();
		Console.ReadLine();
	}
}
