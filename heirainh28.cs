//28.heirarchycal inheritance
using System;
class heirainh28
{
	static void Main()
	{
		child1 c1=new child1();
		child2 c2=new child2();
		child3 c3=new child3();
		c1.print1();
		c2.print2();
		c3.print3();
	}
}
public class par
{
	protected void print()
	{
		Console.WriteLine("hello parent class.");
	}
}
public class child1 : par
{
	public void print1()
	{
		print();
		Console.WriteLine("hello child1 class.");
	}
}
public class child2 : par
{
	public void print2()
	{
		print();
		Console.WriteLine("hello child2 class.");
	}
}
public class child3 : par
{
	public void print3()
	{
		print();
		Console.WriteLine("hello child3 class.");
	}
}