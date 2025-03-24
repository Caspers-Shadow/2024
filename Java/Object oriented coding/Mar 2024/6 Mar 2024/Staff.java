public class Staff extends Employee
{
	private String staffTitle;
	
	public Staff()
	{
		this("","","");		
	}
	
	public Staff(String ID, String name, String email)
	{
		super(ID,name,email);
		setTitle("");
	}
	
	/**
	 setting- and getting Title
	*/
	
	public void setTitle(String title)
	{
		staffTitle = title;
	}
	
	public String getTitle()
	{
		return staffTitle;
	}
	
	/**
	 The toString method for the class student
	*/
	
	public String toString()
	{
		return "\nStaff title: " + staffTitle;
	}
}