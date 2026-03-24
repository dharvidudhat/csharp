//27.hierarchycal inheritance and find square
using System;
class multilevsqr27
{
	static void Main()
	{
		pqr p=new pqr();
		int a=p.val();
		Console.WriteLine("square is "+a);
		Console.ReadLine();
	}
}

public class abc  //parent class
{
	protected int findsqr(int a)
	{
		return a*a;
	}
}

public class xyz : abc //child class
{
	protected int print(int x)
	{
		int r;
		Console.WriteLine("square of "+x);
		r=findsqr(x);
		return r;
	}
}

public class pqr : xyz  // child class
{
	public int val()
	{
		Console.Write("enter square value : ");
		int v=Convert.ToInt32(Console.ReadLine());
		int p=print(v);
		return p;
	}
}