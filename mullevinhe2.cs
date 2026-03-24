//multi level inheritance
using System;
class mullevinhe2
{
	static void Main()
	{
		
		pqr p=new pqr(); //sub child class object
		p.method();
		p.print();
		Console.ReadLine();
	}
}

public class abc  //super parent class
{
	protected void display()
	{
		Console.WriteLine("hello display.");
	}
}

public class xyz : abc //child class
{
	public void print()
	{
		Console.WriteLine("hello print.");
	}
}

public class pqr : xyz  //sub child class
{
	public void method()
	{
		Console.WriteLine("hello sub child.");
		display();  //protected method calling
		Console.WriteLine("back to sub child.");
	}
}