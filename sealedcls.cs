//sealed class
using System;
class sealedcls
{
	static void Main()
	{
		pqr p=new pqr();
		xyz x=new xyz();
		p.method1();
		p.method2();
		
		x.method3();
		x.method1();
		Console.ReadLine();
	}
}
public class abc
{
	public void method1()
	{
		Console.WriteLine("hello abc.");
	}
}
public sealed class pqr : abc
{
	public void method2()
	{
		Console.WriteLine("hello pqr.");
	}
}
public class xyz : abc
{
	public void method3()
	{
		Console.WriteLine("hello xyz.");
	}
}