//2d array
using System;
class array
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
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<3;j++)
			{
				Console.WriteLine(a[i,j]);
			}
		}
	}
}