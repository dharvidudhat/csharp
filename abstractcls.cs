//abstract class
using System;
class abstractcls
{
	static void Main()
	{
		//abc a=new abc() we can not create object because it is abstract class
		xyz x=new xyz();
		x.fun();
		Console.ReadLine();
	}
}
public abstract class abc //abstract class always be parent
{
	public void fun()
	{
		Console.WriteLine("hello abc.");
	}
}
public class xyz : abc
{}