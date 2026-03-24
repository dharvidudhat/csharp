//working with data member with different object
using System;
class memdifobj
{
	static void Main()
	{
		abc a=new abc(5);
		a.show();
		abc b=new abc(67);
		b.show();
		Console.ReadLine();
		
	}
}
class abc
{
	int x;
	public abc(int t)
	{
		x=t;
		Console.WriteLine("hello class.");
	}
	public void show()
	{
		Console.WriteLine("value of  x  : "+x);
	}
}