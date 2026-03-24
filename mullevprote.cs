//multi level inheritance with protected method
using System;
class mullevprote
{
	static void Main()
	{
		
		pqr p=new pqr(); //sub child class object
		p.method();
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