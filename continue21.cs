//21.continue using switch case 
using System;
class continue21
{
	static void Main()
	{
		String []ad={"monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
		for(int i=0;i<ad.Length;i++)
		{
			switch(i)
			{
			
				case 5:
					Console.WriteLine((i+1)+"."+ad[i]+" is skip because it's holiday.");
					continue;
				case 6:
					Console.WriteLine((i+1)+"."+ad[i]+" is skip because it's holiday.");
					continue;
				 default: 
					Console.WriteLine((i+1)+"."+ad[i]+" is process day.");
					break;
				
			}
		}
	}
}