public class Student extends Person
{
	private String studStatus;
	
	public Student()
	{
		this("","","");		
	}
	
	public Student(String ID, String name, String email)
	{
		super(ID, name, email);
		setStatus("");
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
	 The toString method for the class student
	*/
	
	public String toString()
	{
		return "\nStudent status: " + studStatus ;
	}
}