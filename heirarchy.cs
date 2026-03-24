//hierarchycal inheritance
using System;
class heirarchy
{
	static void Main()
	{
		xyz x=new xyz();  //xyz child class object
		pqr p=new pqr(); //pqr child class object
		p.method();
		x.print();
		Console.ReadLine();
	}
}

public class abc  //parent class
{
	protected void display()
	{
		Console.WriteLine("hello parent.");
	}
}

public class xyz : abc //child class
{
	public void print()
	{
		Console.WriteLine("hello xyz child.");
		display();
		Console.WriteLine("back to xyz child.");
	}
}

public class pqr : abc  // child class
{
	public void method()
	{
		Console.WriteLine("hello pqr child.");
		display();  //protected method calling
		Console.WriteLine("back to pqr child.");
	}
}