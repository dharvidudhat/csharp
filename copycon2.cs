//copy constructor2
using System;
class copycon2
{
	static void Main()
	{
		demo d=new demo(10); //int type
		demo d1=new demo(d); //demo type
		d.show();
		d1.show();
		Console.ReadLine();
	}
}
class demo
{
	int x;
	public demo(int c) //parameter constructor
	{
		x=c;
		Console.WriteLine("hello parameter constructor.");
	}
	public demo(demo obj)
	{
		x=obj.x;
		Console.WriteLine("hello copy constructor.");
	}
	public void show()
	{
		Console.WriteLine("value of x : "+x);
	}
}