// read (get) and write (set) both property
using System;
class setgetpro
{
	static void Main()
	{
		abc a=new abc();
		a.pro=20; 	//set value  a.x=20;
		Console.WriteLine("value of x :"+a.pro);	//get value Console.WriteLine(a.x)
		Console.ReadLine();
		
	}
}
class abc
{
	int x;
	public int pro
	{
		set
		{
			x=value;
		}
		get
		{
			return x;
		}
	}
}