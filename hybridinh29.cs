//29.hybrid inheritance example
using System;
class hybridinh29
{
	static void Main()
	{
		child1 c1=new child1(); //child1 object 
		subchild s=new subchild();  //subchild object 
		child3 c3=new child3();  //child3 object
		c1.print1();  //call child1 method
		s.subprint();  //call subchild method
		c3.print3(); //call child3 method
	}
}
public class suppar
{
	protected void display()
	{
		Console.WriteLine("hello super parent or parent class.");
	}
}
public class child1 : suppar //suppar->child1
{
	public void print1()
	{
		display();
		Console.WriteLine("hello child1 class.");
	}
}
public class child2 : suppar  //suppar->child2
{
	protected void print2()
	{
		Console.WriteLine("hello child2 class.");
	}
}
public class subchild : child2  //suppar->child2->subchild
{
	public void subprint()
	{
		display();
		print2();
		Console.WriteLine("hello child2's subchild class.");
	}
}
public class child3 : suppar  //suppar->child3
{
	public void print3()
	{
		display();
		Console.WriteLine("hello child3 class.");
	}
}