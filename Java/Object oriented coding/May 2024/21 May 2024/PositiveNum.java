public class PositiveNum
{
	public static int recursive(int n)
	{
		if(n == 1)
		{
			return 1;			
		}
		else
		{
			return recursive(n-1)+ n;
		}
	}
	
	public static void main(String args[])
	{
		System.out.println("\n\n====Positive numbers====\n");
		for(int i = 0; i < 10; i++)
		{
			System.out.println("The recursive sum for " + i + " is : " + recursive(i));
		}
	}
}