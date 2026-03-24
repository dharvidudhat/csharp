//ref keyword
using System;
class refkey32
{
	static void Main()
	{
		abc a=new abc();
		int x=20,y=50;
		Console.WriteLine("valur of x : "+x);
		Console.WriteLine("valur of y : "+y);
		a.m1(ref x,ref y);
		Console.WriteLine("sum is : "+x);
		Console.WriteLine("substraction is : "+y);
		Console.ReadLine();
	}
}
class abc
{
	public void m1(ref int a,ref int b)
	{
		a+=10;
		b-=10;
	}
}
