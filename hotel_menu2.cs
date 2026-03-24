//hotel menu using switch case
using System;
class hotel_menu2
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
		int index = -1;
		do
		{
			
			Console.WriteLine("1.	pizza			rs.150");
			Console.WriteLine("2.	pasta		        rs.200");
			Console.WriteLine("3.	tacos			rs.50");
			Console.WriteLine("4.	donut			rs.100");
			Console.WriteLine("5.	frice			rs.150");
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
					index = -1;

					// check item already exists
					for (int j = 0; j < i; j++)
					{
						if (a[j] == "Pizza")   // change name for each case
						{
							index = j;
							break;
						}
					}

					if (index != -1)
					{
						a2[index] += qty;              // increase quantity
						 t[index] = a1[index] * a2[index];
					}
					else
					{
						a[i] = "Pizza";
						a1[i] = 150;
						a2[i] = qty;
						t[i] = 150 * qty;
						i++;
					}
					break;
					
				case 2:
					Console.WriteLine("you select pasta rs.200");
					Console.Write("enter qty of pasta : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(200*qty);
					index = -1;
					
					// check item already exists
					for (int j = 0; j < i; j++)
					{
						if (a[j] == "pasta")   // change name for each case
						{
							index = j;
							break;
						}
					}

					if (index != -1)
					{
						a2[index] += qty;              // increase quantity
						 t[index] = a1[index] * a2[index];
					}
					else
					{
					 a[i]="pasta";
					 a1[i]=200;
					 a2[i]=qty;
					 t[i]=200*qty;
					 i++;
					}
					break;
					
				case 3:
					Console.WriteLine("you select tacos rs.50");
					Console.Write("enter qty of tacos : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(50*qty);
					index = -1;
					
					// check item already exists
					for (int j = 0; j < i; j++)
					{
						if (a[j] == "tacos")   // change name for each case
						{
							index = j;
							break;
						}
					}

					if (index != -1)
					{
						a2[index] += qty;              // increase quantity
						 t[index] = a1[index] * a2[index];
					}
					else
					{
					 a[i]="tacos";
					 a1[i]=50;
					 a2[i]=qty;
					 t[i]=50*qty;
					 i++;
					}
					break;
					
				case 4:
					Console.WriteLine("you select donut rs.100");
					Console.Write("enter qty of donut : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(100*qty);
					index = -1;
					
					// check item already exists
					for (int j = 0; j < i; j++)
					{
						if (a[j] == "donut")   // change name for each case
						{
							index = j;
							break;
						}
					}

					if (index != -1)
					{
						a2[index] += qty;              // increase quantity
						 t[index] = a1[index] * a2[index];
					}
					else
					{
					 a[i] = "donut";
					 a1[i]=100;
					 a2[i]=qty;
					 t[i]=100*qty;
					 i++;
					}
					break;
					
				case 5:
					Console.WriteLine("you select frice rs.150");
					Console.Write("enter qty of frice : ");
					qty=Convert.ToInt32(Console.ReadLine());
					total=total+(150*qty);
					index = -1;
					
					// check item already exists
					for (int j = 0; j < i; j++)
					{
						if (a[j] == "frice")   // change name for each case
						{
							index = j;
							break;
						}
					}

					if (index != -1)
					{
						a2[index] += qty;              // increase quantity
						 t[index] = a1[index] * a2[index];
					}
					else
					{
					 a[i] = "frice";
					 a1[i]=150;
					 a2[i]=qty;
					 t[i]=150*qty;
					 i++;
					}
					break;
			}
			Console.WriteLine();
			Console.Write("do you want to continue ?(yes/no) : ");
			q=Console.ReadLine();
		}while(q=="yes");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("----Bill----");
		Console.WriteLine();
		Console.WriteLine("item \trs. \tqty \ttotal");
		Console.WriteLine();
		Console.WriteLine("---------------------------------");
		for (int j = 0; j < i; j++)
        {
            Console.WriteLine(a[j]+" \t"+a1[j]+" \t"+a2[j]+" \t"+t[j]);
        }
		Console.WriteLine("---------------------------------");
        Console.WriteLine(" 	Total Amount =" + total);
		Console.WriteLine();
		Console.WriteLine("thank you visit again..");
	}
}