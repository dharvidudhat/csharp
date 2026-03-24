//30.method overloading
using System;
class mtdoverload30
{
	static void Main()
	{
		demo d=new demo();
		d.method();
		d.method(10.5);
		d.method("dharvi");
		d.method(50);
	}
}
public class demo
{
	public  void method()
	{
		Console.WriteLine("hello default method");
	}
	public void method(int a)
	{
		Console.WriteLine("hello method with integer value : "+a);
	}
	public void method(double d)
	{
		Console.WriteLine("hello method with double value : "+d);
	}
	public void method(String s)
	{
		Console.WriteLine("hello method with string value : "+s);
	}
}
