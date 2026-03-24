//38.multi cast delegate
using System;
public delegate void mydel(int a);
class demo
{
	public void sqr(int a)
	{
		int s=a*a;
		Console.WriteLine("squre is : "+s);
	}
	public void cube(int a)
	{
		int c=a*a*a;
		Console.WriteLine("cube is : "+c);
	}
}
class multidele38
{
	static void Main()
	{
		demo d=new demo();
		mydel del=new mydel(d.sqr);
		Console.WriteLine("enter numbr to find sqr and cube : ");
		int u=Convert.ToInt32(Console.ReadLine());
		del+=d.cube;
		del(u);
		
	}
}