public class Student
{
	private String studID;
	private String studName;
	private String studStatus;
	private String studEmail;
	
	public Student()
	{
		this("","","");		
	}
	
	public Student(String ID, String name, String email)
	{
		setID(ID);
		setName(name);
		setEmail(email);
		setStatus("");
	}
	
	/**
	 setting- and getting ID number
	*/
	
	public void setID(String ID)
	{
		studID = ID;
	}
	
	public String getID()
	{
		return studID;
	}
	
	/**
	 setting- and getting Name
	*/
	
	public void setName(String name)
	{
		studName = name;
	}
	
	public String getName()
	{
		return studName;
	}
	
	/**
	 setting- and getting Status
	*/
	
	public void setStatus(String status)
	{
		studStatus = status;
	}
	
	public String getStatus()
	{
		return studStatus;
	}
	
	/**
	 setting- and getting email address
	*/
	
	public void setEmail(String email)
	{
		studEmail = email;
	}
	
	public String getEmail()
	{
		return studEmail;
	}
	
	/**
	 The toString method for the class student
	*/
	
	public String toString()
	{
		return "\nStudent ID: " + studID +"\nStudent Name: " + studName +"\nStudent status: " + studStatus +"\nStudent e-mail: " + studEmail ;
	}
}