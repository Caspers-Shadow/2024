public class Person
{
	private String name;
	
	public Person()
	{
		this("");
	}
	
	public Person(String sName)
	{
		setPerson(sName);
	}
	
	public void setPerson(String sName)
	{
		name = sName;
	}
	
	public String getPerson()
	{
		return name;
	}
	
	public String toString()
	{
		return "Your name is : " + name;
	}
}