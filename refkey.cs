//ref keyword
using System;
class refkey
{
	static void Main()
	{
		abc a=new abc();
		int x=20;
		Console.WriteLine(" before valur of x : "+x);
		a.m1(ref x);
		Console.WriteLine(" after valur of x : "+x);
		Console.ReadLine();
	}
}
class abc
{
	public void m1(ref int a)
	{
		Console.WriteLine(" before valur of a : "+a);
		a+=10;
		Console.WriteLine(" after valur of a : "+a);
	}
}
