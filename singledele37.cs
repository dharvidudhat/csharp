//37.single cast delegate
using System;
public delegate void dele(int a,int b);
class demo
{
	public void sum(int a,int b)
	{
		int ans=a+b;
		Console.WriteLine("sum is : "+ans);
	}
}
class singledele37
{
	static void Main()
	{
		demo d=new demo();
		Console.Write("enter number1 : ");
		int num1=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter number2 : ");
		int num2=Convert.ToInt32(Console.ReadLine());
		dele de=new dele(d.sum);
		de(num1,num2);
		Console.ReadLine();
	}
}