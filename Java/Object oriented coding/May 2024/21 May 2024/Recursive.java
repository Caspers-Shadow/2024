public class Recursive
{
	public static int recursive(int n)
	{
		if(n <= 1)
		{
			return n;			
		}
		else
		{
			return recursive(n-1)+recursive(n-2);
		}
	}
	
	public static void main(String args[])
	{
		System.out.println("\n\n====RECURSIVE====\n");
		for(int i = 0; i < 12; i++)
		{
			System.out.println("The " + i + " term is : " + recursive(i));
		}
	}
}