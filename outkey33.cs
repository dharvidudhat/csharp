//out keyword
using System;
class outkey33
{
	static void Main()
	{
		abc a=new abc();
		int x,y;
		a.m1(out x,out y);
		Console.WriteLine("square is "+x);
		Console.WriteLine("cube is "+y);
		Console.ReadLine();
	}
}
class abc
{
	public void m1(out int a,out int b)
	{
		Console.Write("enter number of found square : ");
		a=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter number of found cube : ");
		b=Convert.ToInt32(Console.ReadLine());
		a=a*a;
		b=b*b*b;
	}
}
