//abstract method
using System;
class abstractmtd
{
	static void Main()
	{
		//abc a=new abc() we can not create object because it is abstract class
		xyz x=new xyz();
		x.fun();
		x.abs();
		Console.ReadLine();
	}
}
public abstract class abc //abstract class always be parent
{
	public abstract void abs();
	public void fun()
	{
		Console.WriteLine("hello abc.");
	}
}
public class xyz : abc
{
	public override void abs()
	{
		Console.WriteLine("hello abstract method.");
	}
}