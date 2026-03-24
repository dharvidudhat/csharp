//else if ladder positive negative and zero
using System;
class else_if 
{
	static void Main()
	{
		Console.Write("enter number : ");
		int n=Convert.ToInt32(Console.ReadLine());
		if(n>0)
		{
			Console.WriteLine("number is positive.");
		}
		else if(n<0)
		{
			Console.WriteLine("number is negative.");
		}
		else
		{
			Console.WriteLine("number is zero.");
		}
	}
}