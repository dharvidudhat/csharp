//assign value from parent data member
using System;
class parentdataval2
{
	static void Main()
	{
		abc obj=new abc();  //parent
		xyz obj2=new xyz();  //child
		obj2.show();
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
{
		public void show()
		{
			a=20;
			Console.WriteLine("this is show.");
			display();
		}
}