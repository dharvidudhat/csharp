//13:2d array element and size from user
using System;
class arruser13
{
	static void Main()
	{
		Console.Write("enter row size : ");
		int r=Convert.ToInt32(Console.ReadLine());
		
		Console.Write("enter column size : ");
		int c=Convert.ToInt32(Console.ReadLine());
		
		int [,]arr=new int[r,c];
		
		
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write("arr["+i+","+j+"] : ");
				arr[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		
		
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write("arr["+i+","+j+"] : "+arr[i,j]+"		");
			}
			Console.WriteLine();
		}
	}
}