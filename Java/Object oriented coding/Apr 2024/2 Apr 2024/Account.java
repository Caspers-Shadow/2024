public abstract class Account implements Interest
{
	private String accNum;
	private int accBalance;
	
	/**
	Constructors
	*/
	
	public Account()
	{
		this("0000000000",0);
		
	}
	
	public Account(String num, int balance)
	{
		setAccountNumber(num);
		setBalance(balance);
	}
	
	/**
	Setting- and getting the account numbers
	*/
	
	public void setAccountNumber(String num)
	{
		accNum = num;
	}
	
	public String getAccountNumber()
	{
		return accNum;
	}
	
	/**
	Setting- and getting the account balance
	*/
	
	public void setBalance(int balance)
	{
		accBalance = balance;
	}
	
	public int getBalance()
	{
		return accBalance;
	}
	
	/**
	toString method
	*/
	
	public String toString()
	{
		return "Account umber: " +accNum + "\nAccount balance: " + accBalance;
	}
	
}