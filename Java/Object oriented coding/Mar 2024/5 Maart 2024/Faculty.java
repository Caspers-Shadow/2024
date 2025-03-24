public class Faculty
{
	private String facID;
	private String facName;
	private String facRank;
	private String facEmail;
	private String facOffice;
	
	public Faculty()
	{
		this("","","","");		
	}
	
	public Faculty(String ID, String name, String email, String rank)
	{
		setID(ID);
		setName(name);
		setEmail(email);
		setRank(rank);
		
		setOffice("");
	}
	
	/**
	 setting- and getting ID number
	*/
	
	public void setID(String ID)
	{
		facID = ID;
	}
	
	public String getID()
	{
		return facID;
	}
	
	/**
	 setting- and getting Name
	*/
	
	public void setName(String name)
	{
		facName = name;
	}
	
	public String getName()
	{
		return facName;
	}
	
	/**
	 setting- and getting Rank
	*/
	
	public void setRank(String rank)
	{
		facRank = rank;
	}
	
	public String getRank()
	{
		return facRank;
	}
	
	/**
	 setting- and getting Office
	*/
	
	public void setOffice(String office)
	{
		facOffice = office;
	}
	
	public String getOffice()
	{
		return facOffice;
	}
	
	/**
	 setting- and getting email address
	*/
	
	public void setEmail(String email)
	{
		facEmail = email;
	}
	
	public String getEmail()
	{
		return facEmail;
	}
	
	/**
	 The toString method for the class student
	*/
	
	public String toString()
	{
		return "\nFaculty ID: " + facID +"\nFaculty Name: " + facName +"\nFaculty Rank: " + facRank +"\nFaculty e-mail: " + facEmail + "\nFaculty office: " + facOffice;
	}
}