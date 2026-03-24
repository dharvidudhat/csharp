//default constructor
using System;
class defaultcon
{
	static void Main()
	{
		demo d=new demo();
		demo d1=new demo();
		Console.ReadLine();
	}
}
public class demo
{
	public demo()
	{
		Console.WriteLine("hello constructor");
	}
}