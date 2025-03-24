public class Staff
{
	private String staffID;
	private String staffName;
	private String staffTitle;
	private String staffOffice;
	private String staffEmail;
	
	public Staff()
	{
		this("","","","");		
	}
	
	public Staff(String ID, String name, String email, String title)
	{
		setID(ID);
		setName(name);
		setEmail(email);
		setTitle(title);
		setOffice("");
	}
	
	/**
	 setting- and getting ID number
	*/
	
	public void setID(String ID)
	{
		staffID = ID;
	}
	
	public String getID()
	{
		return staffID;
	}
	
	/**
	 setting- and getting Name
	*/
	
	public void setName(String name)
	{
		staffName = name;
	}
	
	public String getName()
	{
		return staffName;
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
	 setting- and getting Office
	*/
	
	public void setOffice(String office)
	{
		staffOffice = office;
	}
	
	public String getOffice()
	{
		return staffOffice;
	}
	
	/**
	 setting- and getting email address
	*/
	
	public void setEmail(String email)
	{
		staffEmail = email;
	}
	
	public String getEmail()
	{
		return staffEmail;
	}
	
	/**
	 The toString method for the class student
	*/
	
	public String toString()
	{
		return "\nStaff ID: " + staffID +"\nStaff Name: " + staffName +"\nStaff title: " + staffTitle +"\nStaff Office: " + staffOffice +"\nStaff e-mail: " + staffEmail;
	}
}