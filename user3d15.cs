//15: 3d array value from user
using System;
class user3d15
{
	 static void Main()
	 {
		 Console.Write("enter dimensional size : ");
		 int d=Convert.ToInt32(Console.ReadLine());
		 Console.Write("enter row size : ");
		 int r=Convert.ToInt32(Console.ReadLine());
		 Console.Write("enter column size : ");
		 int c=Convert.ToInt32(Console.ReadLine());
		 int [,,]arr=new int[d,r,c];
		 
		 for(int i=0;i<arr.GetLength(0);i++)
		 {
			 for(int j=0;j<arr.GetLength(1);j++)
			 {
				 for(int k=0;k<arr.GetLength(2);k++)
				 {
					 Console.Write("enter arr["+i+","+j+","+k+"] : ");
					 arr[i,j,k]=Convert.ToInt32(Console.ReadLine());
				 }
			 }
		 }
		 
		  for(int i=0;i<arr.GetLength(0);i++)
		 {
			 for(int j=0;j<arr.GetLength(1);j++)
			 {
				 for(int k=0;k<arr.GetLength(2);k++)
				 {
					 Console.Write("arr["+i+","+j+","+k+"] : "+arr[i,j,k]+"		");
					 
				 }
				 Console.WriteLine();
			 }
			 Console.WriteLine();
			 Console.WriteLine();
		 }
	 }
}