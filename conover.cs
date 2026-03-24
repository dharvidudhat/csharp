//constructor overloading
using System;
class conover
{
	static void Main()
	{
		demo d=new demo();
		demo d1=new demo(15);
		Console.ReadLine();
	}
}
public class demo
{
	public demo()
	{
		Console.WriteLine("hello constructor with default .");
	}
	public demo(int a)
	{
		Console.WriteLine("hello constructor with parameter .");
	}
}