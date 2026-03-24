//hotel menu using switch case
using System;
class hotel_menu
{
	static int i=0;
	static void Main()
	{
		String q;
		String []a=new String[20];
		int []a1=new int[20];
		int []a2=new int[20];
		int []t=new int[20];
		int choice,qty,total=0;
		do
		{
			
			Console.WriteLine("1.	pizza			rs.150");
			Console.WriteLine("2.	manchurium		rs.200");
			Console.WriteLine("3.	vadapav			rs.50");
			Console.WriteLine("4.	maggie			rs.100");
			Console.WriteLine("5.	fried rice		rs.150");
			Console.WriteLine();
			
			Console.Write("enter your choice : ");
			choice=Convert.ToInt32(Console.ReadLine());
			
			switch(choice)
			{
				case 1:
					Console.WriteLine("you select pizza rs.150");
					Console.Write("enter qty of pizza : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(150*qty);
					  a[i] = "Pizza";
					  a1[i] = 150;
                      a2[i] = qty;
					  t[i]=150*qty;
                      i++;
					break;
				case 2:
					Console.WriteLine("you select manchurium rs.200");
					Console.Write("enter qty of manchurium : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(200*qty);
					 a[i]="manchurium";
					 a1[i]=200;
					 a2[i]=qty;
					 t[i]=200*qty;
					 i++;
					break;
				case 3:
					Console.WriteLine("you select vadapav rs.50");
					Console.Write("enter qty of vadapav : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(50*qty);
					 a[i]="vadapav";
					 a1[i]=50;
					 a2[i]=qty;
					 t[i]=50*qty;
					 i++;
					break;
				case 4:
					Console.WriteLine("you select maggie rs.100");
					Console.Write("enter qty of maggie : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(100*qty);
					 a[i] = "maggie";
					 a1[i]=100;
					 a2[i]=qty;
					 t[i]=100*qty;
					 i++;
					break;
				case 5:
					Console.WriteLine("you select fried rice rs.150");
					Console.Write("enter qty of fried rice : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(150*qty);
					 a[i] = "fried rice";
					 a1[i]=150;
					 a2[i]=qty;
					 t[i]=150*qty;
					 i++;
					break;
			}
			Console.WriteLine();
			Console.Write("do you want to continue ?(yes/no) : ");
			q=Console.ReadLine();
		}while(q=="yes");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("----Bill----");
		for (int j = 0; j < i; j++)
        {
            Console.WriteLine(a[j]+" rs."+a1[j]+" qty is "+a2[j]+"  total "+t[j]);
        }

        Console.WriteLine("Total Amount = Rs." + total);
		Console.WriteLine();
		Console.WriteLine("thank you visit again..");
	}
}