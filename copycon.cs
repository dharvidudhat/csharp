//copy constructor
using System;
class copycon
{
	static void Main()
	{
		demo d=new demo(10); //int type
		demo d1=new demo(d); //demo type
		Console.ReadLine();
	}
}
class demo
{
	public demo(int c) //parameter constructor
	{
		Console.WriteLine("hello parameter constructor.");
	}
	public demo(demo obj)
	{
		Console.WriteLine("hello copy constructor.");
	}
}