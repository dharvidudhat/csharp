//24.how to assign value public data member from user  in another class and print values another class.
using System;
class publicmem24
{
	static void Main()
	{
		xyz obj1=new xyz();
		xyz obj2=new xyz();
		Console.Write("enter value of obj1.a : ");
		obj1.a=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter value of obj2.a : ");
		obj2.a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("value of a using obj1 : "+obj1.a);
		Console.WriteLine("value of a using obj2 : "+obj2.a);
		Console.ReadLine();
	}
}
public class xyz
{
	public int a;
}