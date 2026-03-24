//static constructor
using System;
class staticcon
{
	static void Main()
	{
		xyz obj1=new xyz();
		xyz obj2=new xyz();
		Console.ReadLine();
	}
}
public class xyz
{
	public xyz()
	{
		Console.WriteLine("hello normal constructor.");
	}
	static xyz()
	{
		Console.WriteLine("hello static constructor.");
	}
}