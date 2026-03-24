//destructor
using System;
class destruct
{
	static void Main()
	{
		demo d=new demo();
		demo d1=new demo();
		Console.ReadLine();
		Console.WriteLine("main complete.");
	}
}
public class demo
{
	public demo()
	{
		Console.WriteLine("constructor.");
	}
	~demo()
	{
		Console.WriteLine("destructor.");
	}
}