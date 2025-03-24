public class Person
{
	private String newEmail;
	private String newID;
	private String newName;
	
	public Person()
	{
		this("","","");		
	}
	
	public Person(String ID, String name, String email)
	{
		setID(ID);
		setName(name);
		setEmail(email);
	}
	
	/**
	 setting- and getting ID number
	*/
	
	public void setID(String ID)
	{
		newID = ID;
	}
	
	public String getID()
	{
		return newID;
	}
	
	/**
	 setting- and getting Name
	*/
	
	public void setName(String name)
	{
		newName = name;
	}
	
	public String getName()
	{
		return newName;
	}
	
	/**
	 setting- and getting email address
	*/
	
	public void setEmail(String email)
	{
		newEmail = email;
	}
	
	public String getEmail()
	{
		return newEmail;
	}
	
	/**
	 The toString method for the class Person
	*/
	
	public String toString()
	{
		return "\nID: " + newID +"\nName: " + newName +"\nE-mail: " + newEmail ;
	}
}