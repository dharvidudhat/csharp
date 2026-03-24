//GetLength() function
using System;
class arr2d
{
	static void Main()
	{
		int [,]a=new int[2,3];
		a[0,0]=10;
		a[0,1]=20;
		a[0,2]=30;
		a[1,0]=50;
		a[1,1]=160;
		a[1,2]=106;
		Console.WriteLine("total element of array is : "+a.Length);
		Console.WriteLine("total row of array is : "+a.GetLength(0));
		Console.WriteLine("total column of array is : "+a.GetLength(1));
		for(int i=0;i<a.GetLength(0);i++)
		{
			for(int j=0;j<a.GetLength(1);j++)
			{
				Console.WriteLine(a[i,j]);
			}
		}
	}
}