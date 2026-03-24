//multi level inheritance interface
using System;
class multiinterf
{
	static void Main()
	{
		cls1 c1=new cls1();
		c1.m1();
		c1.m2();
		c1.m3();
		Console.ReadLine();
	}
}
interface intr1
{
	void m1();
}
interface intr2 : intr1
{
	void m2();
}
interface intr3 : intr2
{
	void m3();
}
class cls1 : intr3
{
	public void m1()
	{
		Console.WriteLine("hello method 1.");
	}
	public void m2()
	{
		Console.WriteLine("hello method 2.");
	}
	public void m3()
	{
		Console.WriteLine("hello method 3.");
	}
}