public class InvalidRadiusException extends RuntimeException
{
	public InvalidRadiusException()
	{
		this("Radius is invalid");
	}
	
	public InvalidRadiusException(String s)
	{
		super(s);
	}
}