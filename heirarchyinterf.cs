//heirarchycal inheritance interface
using System;
class heirarchyinterf
{
	static void Main()
	{
		cls1 c1=new cls1();
		cls2 c2=new cls2();
		cls3 c3=new cls3();
		
		//class 1 obj 
		c1.m1();	
		
		//class 2 obj
		c2.m1();	
		c2.m2();
		
	    //class 3 obj
		c3.m1();
		c3.m3();
		Console.ReadLine();
	}
}
interface intr1
{
	void m1();
}
interface intr2 : intr1
{
	void m2();
}
interface intr3 : intr1
{
	void m3();
}
class cls1 : intr1
{
	public void m1()
	{
		Console.WriteLine("hello method 1 of class 1.");
	}
}
class cls2 : intr2
{
	public void m1()
	{
		Console.WriteLine("hello method 1 of class 2.");
	}
	public void m2()
	{
		Console.WriteLine("hello method 2 of class 2.");
	}
}
class cls3 : intr3
{
	public void m1()
	{
		Console.WriteLine("hello method 1 of class 3.");
	}
	public void m3()
	{
		Console.WriteLine("hello method 3 of class 3.");
	}
}