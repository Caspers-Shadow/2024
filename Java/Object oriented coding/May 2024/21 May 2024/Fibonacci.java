public class Fibonacci
{	
	public static void main(String args[])
	{
		System.out.println("====NON-RECURSIVE====\n");
		int term1 = 0;
		int term2 = 1;
		int currentTerm = 0;
		
		System.out.println("The " + term1 + " term is : " + term1);
		System.out.println("The " + term2 + " term is : " + term2);
		
		for(int i = 0; i < 10; i++)
		{
			currentTerm = term1 + term2;
			term1 = term2;
			term2 = currentTerm;
			System.out.println( "The " + (i+2) + " term is : " + currentTerm);
		}	
		
	}
}