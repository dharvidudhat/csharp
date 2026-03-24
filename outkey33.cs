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
		int x=ConvertToINt32(Console.ReadLine());
		int y=ConvertToINt32(Console.ReadLine());
		a=a*a;
		b=b*b*b;
	}
}
