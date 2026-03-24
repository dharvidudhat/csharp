//parameterized constructor
using System;
class paracon
{
	static void Main()
	{
		demo d=new demo(5,10);
		demo d1=new demo(15,20);
		Console.ReadLine();
	}
}
public class demo
{
	public demo(int a,int b)
	{
		Console.WriteLine("hello constructor  "+a+"  "+b);
	}
}