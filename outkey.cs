//out keyword
using System;
class outkey
{
	static void Main()
	{
		abc a=new abc();
		int x=20,y;
		Console.WriteLine(" before valur of x : "+x);
		a.m1(ref x,out y);
		Console.WriteLine(" after valur of x : "+x+" y : "+y);
		Console.ReadLine();
	}
}
class abc
{
	public void m1(ref int a,out int b)
	{
		Console.WriteLine(" before valur of a : "+a);
		a+=10;
		b=80;
		Console.WriteLine(" after valur of a : "+a+" b : "+b);
	}
}
