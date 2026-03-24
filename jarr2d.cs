//16: static jagged array
using System;
class jarr2d
{
	static void Main()
	{
		int [][]a=new int[3][];
		//column size
		a[0]=new int[4];
		a[1]=new int[2];
		a[2]=new int[1];
		//value of elements
		a[0][0]=10;
		a[0][1]=30;
		a[0][2]=3;
		a[0][3]=100;
		a[1][0]=47;
		a[1][1]=33;
		a[2][0]=20;
		//print it
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a[i].Length;j++)
			{
			Console.WriteLine("a["+i+","+j+"] : "+a[i][j]);
			}
		}
	}
	

	
}