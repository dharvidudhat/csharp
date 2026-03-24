//sealed method
using System;
class sealedmtd
{
	static void Main()
	{
		pqr p=new pqr();
		xyz x=new xyz();
		p.method(); //sealed method
		x.method1();
		x.method();
		Console.ReadLine();
	}
}
public class abc
{
	public virtual void method()
	{
		Console.WriteLine("hello abc.");
	}
}
public class pqr : abc
{
	public sealed override void method() 
	//we can not override this method to it's child class of because it is sealed method
	{
		Console.WriteLine("hello pqr.");
	}
}
public class xyz : pqr
{
	public void method1()
	{
		Console.WriteLine("hello xyz.");
	}
}