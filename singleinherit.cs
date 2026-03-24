//single inheritance
using System;
class singleinherit
{
	static void Main()
	{
		abc obj1=new abc(); //parent class object
		xyz obj2=new xyz();  //child class object
		obj1.display(); //abc
		obj2.show();  //xyz
		obj2.display();  //abc -> xyz
		Console.ReadLine();
	}
}
public class abc //parent class
{
	public void display()
	{
		Console.WriteLine("this is display.");
	}
}
public class xyz : abc //child class
{
	public void show()
	{
		Console.WriteLine("this is show.");
	}
}