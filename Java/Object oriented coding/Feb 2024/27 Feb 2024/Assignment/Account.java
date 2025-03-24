//Assignment 1
//43054226 : Mariska Adriaanzen

public class Account
{
	private String accNumber;
	private Integer balance;
	
	public Account() //Default constructor
	{
		this("",0);
	}
	
	public Account(String aNo, Integer bal) //Constructor
	{
		setAccNumber(aNo);
		setBalance(bal);
	}
	
	public void setAccNumber(String aNo)//Account number mutator
	{
		accNumber = aNo;
	}
	
	public String getAccNumber()//Account number accessor
	{
		return accNumber;
	}
	
	public void setBalance(Integer bal)//Balance mutator
	{
		balance = bal;
	}
	
	public Integer setBalance()//Balance mutator
	{
		return balance;
	}
	
	public String toString()//Output string
	{
		return "Account number: " + accNumber + "\nAccount balance: " + balance;
	}
}