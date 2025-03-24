public class Employee extends Person
{
	private String newOffice;
	
	public Employee()
	{
		this("","","");		
	}
	
	public Employee(String ID, String name, String email)
	{
		super(ID, name, email);
	}
	
	/**
	 setting- and getting Office
	*/
	
	public void setOffice(String office)
	{
		newOffice = office;
	}
	
	public String getOffice()
	{
		return newOffice;
	}
	
	/**
	 The toString method for the class Person
	*/
	
	public String toString()
	{
		return "\nOffice: " + newOffice ;
	}
	
}