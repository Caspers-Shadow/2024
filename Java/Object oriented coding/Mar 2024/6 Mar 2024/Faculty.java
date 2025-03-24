public class Faculty extends Employee
{
	private String newRank;
	
	public Faculty()
	{
		this("","","");		
	}
	
	public Faculty(String ID, String name, String email)
	{
		super(ID, name, email);
	}
	
	public void setRank(String rank)
	{
		newRank = rank;
	}
	
	public String getRank()
	{
		return newRank;
	}
	
	/**
	 The toString method for the class student
	*/
	
	public String toString()
	{
		return "\nFaculty Rank: " + newRank;
	}
}