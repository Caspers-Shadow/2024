public class Fibonacci
{
	public static void main(String args[])
	{
		int term1 = 0;
		int term2 = 1;
		currentTerm = 0;
		
		for(int i; i < 12; i++)
		{
			currentTerm = term1+term2;
			term1 = term2;
			term2 = currentTerm;
			System.out.println(currentTerm);
		}
	}
}