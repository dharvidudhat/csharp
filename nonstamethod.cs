//non-static method
using System;
class nonstamethod
{
	public void fun()
	{
		Console.WriteLine("hello fun");
	}
	static void Main()
	{
		nonstamethod obj=new nonstamethod();
		obj.fun();
		Console.ReadLine();
	}
}