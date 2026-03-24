//3d jagged user
using System;
class jarr3duser18
{
	static void Main()
	{
		Console.Write("enter dimensional size :");
		int d=Convert.ToInt32(Console.ReadLine());
		
		int [][][]a=new int[d][][];
		
		//row size
		for(int i=0;i<a.Length;i++)
		{
			Console.Write("enter "+i+" dimension row size: ");
			int r=Convert.ToInt32(Console.ReadLine());
			a[i]=new int[r][];
		}
		Console.WriteLine();
		//column size
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				Console.Write("enter "+i+" dimensional "+j+" row's column size :");
				int n=Convert.ToInt32(Console.ReadLine());
				a[i][j]=new int[n];
			}
		}
		
		//get element
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				for(int k=0;k<a[i][j].Length;k++)
				{
					Console.Write("enter a["+i+"]["+j+"]["+k+"] : ");
					a[i][j][k]=Convert.ToInt32(Console.ReadLine());
				}
			}
		}
		Console.WriteLine();
		
		//value of elements
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				for(int k=0;k<a[i][j].Length;k++)
				{
					Console.Write("a["+i+"]["+j+"]["+k+"] : "+a[i][j][k]+"		");
				
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine();
		}
	}
	

	
}