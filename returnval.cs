//return value from the function
using System; 
class returnval
{
	static void Main()
	{
		abc a=new abc();
		int x=20;
		int r=a.m1(x);
		Console.WriteLine("valur of x : "+x);
		Console.WriteLine("valur of r : "+r);

	}
}
class abc
{
	public int m1(int a)
	{
		a+=10;
		return a;
	}
}