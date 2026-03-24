//multiple class
using System;
class multicls
{
	static void Main()
	{
		demo d=new demo();
		d.fun();
		Console.ReadLine();
	}
}
class demo
{
	public void fun()
	{
		Console.WriteLine("hello");
	}
}