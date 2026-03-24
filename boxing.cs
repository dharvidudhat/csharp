//boxing type casting
using System;
class boxing
{
	static void Main()
	{
		int n=10;
		object o=n;
		//value to reference type
		Console.WriteLine("value type :"+n);
		Console.WriteLine("reference type :"+o);
		Console.ReadLine();
	}
}