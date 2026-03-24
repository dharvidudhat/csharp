//task 11:array size and element value from user & print & its sum
using System;
class array
{
	static void Main()
	{
		int s=0;
		Console.Write("enter array size : ");
		int n=Convert.ToInt32(Console.ReadLine());
		int[] arr=new int[n];
		for(int i=0;i<arr.Length;i++)
		{
			Console.Write("arr["+i+"] : ");
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("value of array element : ");
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine("arr["+i+"] : "+arr[i]);
			s=s+arr[i];
		}
		Console.WriteLine("sum of element is : "+s);
	}
}