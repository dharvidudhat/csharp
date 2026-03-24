// auto implemented property
using System;
class autopro
{
	static void Main()
	{
		abc a=new abc();
		a.pro=100;
		Console.WriteLine("value of property : "+a.pro);
		Console.ReadLine();
		
	}
}
class abc
{
	public int pro{get;set;}
}