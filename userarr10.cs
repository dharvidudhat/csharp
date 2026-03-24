//task 10:get element from user
using System;
class array
{
	static void Main()
	{
		int[] arr=new int[5];
		for(int i=0;i<arr.Length;i++)
		{
			Console.Write("arr["+i+"] : ");
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("value of element:");
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine("arr["+i+"] : "+arr[i]);
		}
	}
}