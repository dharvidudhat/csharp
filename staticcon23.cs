//static constructor,default and parameterized
using System;
class staticcon23
{
	static void Main()
	{
		demo d=new demo();
		demo d1=new demo(15);
	}
}
public class demo
{
	static int v;
	public demo()
	{
		Console.WriteLine("hello default constructor.");
	}
	static demo()
	{
		v=10;
		Console.WriteLine("hello static constructor.with value of v :"+v);
	}
	public demo(int a)
	{
		Console.WriteLine("hello parameterized constructor with parameter value : "+a);
	}
}