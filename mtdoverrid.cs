//method overridding
using System;
class mtdoverrid
{
	static void Main()
	{
		pqr p=new pqr();
		p.method(10);
		p.method(20);
		Console.ReadLine();
	}
}
public class abc
{
	public virtual void method(int a)
	{
		Console.WriteLine("hello parent method with value : "+a);
	}
}
public class pqr : abc
{
	public override void method(int a)
	{
		Console.WriteLine("hello child method with value : "+a);
	}
}