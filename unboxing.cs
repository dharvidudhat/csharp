//unboxing type casting
using System;
class unboxing
{
	static void Main()
	{
		int a;
		object ob=20;
		a=(int)ob;
		Console.WriteLine("referance type :"+ob);
		Console.WriteLine("value type :"+a);
		Console.ReadLine();
	}
}