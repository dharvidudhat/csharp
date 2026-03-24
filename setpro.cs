// write (set) only property
using System;
class setpro
{
	static void Main()
	{
		abc a=new abc();
		a.pro=20; 	//set value  a.x=20;
		a.show();
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
		
	}
	public void show()
	{
		Console.WriteLine("value of x in class inside : "+x);
	}
}