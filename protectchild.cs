//protected member with child class
using System;
class protectchild
{
	static void Main()
	{
		xyz obj=new xyz();  //child
		obj.show();
		obj.show();
		Console.ReadLine();
	}
}
public class abc
{
	protected void display()
	{
		Console.WriteLine("this is display.");
	}
}
public class xyz : abc
{
	public void show()
	{
		Console.WriteLine("this is show.");
		hello();
		display();
	}
	public void hello()
	{
		Console.WriteLine("this is hello.");
	}
}