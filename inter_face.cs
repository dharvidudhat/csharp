//interface
using System;
class inter_face
{
	static void Main()
	{
		cls c=new cls();
		c.msg();
		Console.ReadLine();
	}
}
interface inter
{
	void msg();
}
public class cls : inter
{
	public void msg()
	{
		Console.WriteLine("good morning..");
	}
}