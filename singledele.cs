//single cast delegate
using System;
public delegate void mydel(int a);
class demo
{
	public void fun(int a)
	{
		Console.WriteLine("hello fun "+a);
	}
}
class singledele
{
	static void Main()
	{
		demo d=new demo();
		mydel del=new mydel(d.fun);
		del(76); 	//same as d.fun()
	}
}