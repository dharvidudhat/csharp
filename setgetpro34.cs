//set and get property from user
using System;
class setgetpro34
{
	static void Main()
	{
		abc a=new abc();
		
		Console.Write("enter name 1 : ");
		a.pro1=Console.ReadLine();
		Console.WriteLine("name is "+a.pro1);
		
		Console.Write("enter name 2 : ");
		a.pro2=Console.ReadLine();
		a.display();
		
		Console.Write("enter name 3 : ");
		a.assign();
		Console.WriteLine("name is "+a.pro3);
		
	}
}
class abc
{
	string nm;
	public string pro1
	{
		set
		{
			nm=value;
		}
		get
		{
			return nm;
		}
	}
	public string pro2
	{
		set
		{
			nm=value;
		}
	}
	public string pro3
	{
		get
		{
			return nm;
		}
	}
	public void assign()
	{
		nm=Console.ReadLine();
	}
	public void display()
	{
		Console.WriteLine("name is "+nm);
	}
}