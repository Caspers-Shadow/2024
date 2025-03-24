public class InvalidAccountNumber extends RuntimeException
{
	public InvalidAccountNumber()
	{
		this("The account number is invalid");
	}
	
	public InvalidAccountNumber(String s)
	{
		super(s);
	}
}