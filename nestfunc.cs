//nesting of function calling
using System;
class nestfunc
{
	static void Main()
	{
		xyz obj1=new xyz(); //child
		obj1.show();
		obj1.show();
		obj1.display();  //parent method
		Console.ReadLine();
	}
}
public class abc  //parent 
{
	public void display()
	{
		Console.WriteLine("this is display.");
	}
}
public class xyz : abc //child
{
	public void show()
	{
		Console.WriteLine("this is show.");
		hello();  //it self
		display();  //parent
	}
	public void hello()
	{
		Console.WriteLine("this is hello.");
	}
}