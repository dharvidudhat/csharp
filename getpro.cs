// read (get) only property
using System;
class getpro
{
	static void Main()
	{
		abc a=new abc();
		a.assign();
		Console.WriteLine("value of x outside of class : "+a.pro);
		Console.ReadLine();
		
	}
}
class abc
{
	int x;
	public int pro
	{
		get
		{
			return x;
		}
		
	}
	public void assign()
	{
		x=90;
	}
}