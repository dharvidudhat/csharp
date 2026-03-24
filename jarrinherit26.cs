//jagged array in inheritance to print E
using System;
class jarrinherit2
{
	static void Main()
	{
		int a1=0;
		chil c =new chil();
		par p=new par();
	
		for(int i=0;i<c.a.Length;i++)
		{
			for(int j=0;j<c.a[i].Length;j++)
			{
				
				if(a1==9)
				{
					a1=0;
				}
				a1++;
				c.a[i][j]=a1;
			}
		}
		
		c.display();
	}
}
public class par
{
	public int [][]a=new int[5][];
	public par()
	{
		a[0] = new int[5];
		a[1] = new int[1];
		a[2] = new int[3];
		a[3] = new int[1];
		a[4] = new int[5];
	}
}
public class chil : par
{
	public void display()
	{
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
				Console.Write(a[i][j]+" ");
			}
			Console.WriteLine();
		}
	}
}