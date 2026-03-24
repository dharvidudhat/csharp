//multi cast delegate
using System;
public delegate void mydel(int a);
class demo
{
	public void fun(int a)
	{
		Console.WriteLine("hello fun "+a);
	}
}
class demo1
{
	public void fun1(int a)
	{
		Console.WriteLine("hello fun1 "+a);
	}
}
class multidele
{
	static void Main()
	{
		demo d=new demo();
		demo1 d1=new demo1();
		mydel del=new mydel(d.fun);
		del+=d1.fun1;
		del(76);
	}
}