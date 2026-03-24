//2d jagged user
using System;
class jarr2duser17
{
	static void Main()
	{
		Console.WriteLine("enter row size: ");
		int r=Convert.ToInt32(Console.ReadLine());
		
		int [][]a=new int[r][];
		
		//column size
		for(int i=0;i<a.Length;i++)
		{
			Console.WriteLine("enter "+i+" row's column size :");
			int n=Convert.ToInt32(Console.ReadLine());
			a[i]=new int[n];
		}
		
		//get element
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				Console.Write("enter a["+i+","+j+"] : ");
				a[i][j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		
		
		//value of elements
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
			Console.WriteLine("a["+i+","+j+"] : "+a[i][j]);
			}
		}
	}
	

	
}