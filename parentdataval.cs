//assign value from parent data member
using System;
class parentdataval
{
	static void Main()
	{
		abc obj=new abc();  //parent
		xyz obj2=new xyz();  //child
		obj2.a=10;
		obj2.display();
		obj.display();
		Console.ReadLine();
	}
}
public class abc
{
	public int a;
	public void display()
	{
		Console.WriteLine("this is display with value of a :  "+a);
	}
}
public class xyz : abc
{}