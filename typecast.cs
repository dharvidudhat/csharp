//task 9:typecasting
using System;
class typecasting
{
	static void Main()
	{
		int a=10;
		object o=a;  //boxing typecasting
		Console.WriteLine("boxing typecasting :");
		Console.WriteLine("value of a(value type) :"+a);
		Console.WriteLine("value of o(reference type) :"+o);
		int b=(int)o;	//unboxing typecasting
		Console.WriteLine("unboxing typecasting :");
		Console.WriteLine("value of a (reference type) :"+b);
	}
}