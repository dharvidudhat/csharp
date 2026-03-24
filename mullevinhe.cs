//multi level inheritance
using System;
class mullevinhe
{
	static void Main()
	{
		abc a=new abc(); //super parent class object
		xyz x=new xyz(); //child class object
		pqr p=new pqr(); //sub child class object
		a.display();
		x.display();
		p.display();
		Console.ReadLine();
	}
}

public class abc  //super parent class
{
	public void display()
	{
		Console.WriteLine("hello display.");
	}
}

public class xyz : abc //child class
{	
}

public class pqr : xyz  //sub child class
{}