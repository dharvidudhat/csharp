//how to assign value public data member in another class and print values inside the class using method.
using System;
class publicmem
{
	static void Main()
	{
		xyz obj1=new xyz();
		xyz obj2=new xyz();
		obj2.a=20;
		obj1.a=10;
		obj1.show();
		obj2.show();
		Console.ReadLine();
	}
}
public class xyz
{
	public int a;
	public void show()
	{
		Console.WriteLine("value of a :"+a);
	}
}