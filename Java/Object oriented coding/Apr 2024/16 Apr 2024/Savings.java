public class Savings extends Account
{
	private int minBalance;
	
	/**
	Constructors
	*/
	
	public Savings()
	{
		this("00000000",0,0);
		
	}
	
	public Savings(String num, int balance, int minimun)
	{
		super(num,balance);
		setMinimumBalance(minimun);
	}
	
	/**
	Setting- and getting the account numbers
	*/
	
	public void setMinimumBalance(int minimun)
	{
		minBalance = minimun;
	}
	
	public int getMinimumBalance()
	{
		return minBalance;
	}
	
	//ABSTRACT CLASS METHOD
	
	public int calculateInterest(int interestRate)
	{
		int interestEarned = 0;
		int calcBalance = getBalance();
		
        if (calcBalance >= minBalance) 
		{
            interestEarned = (calcBalance * interestRate) / 100;
        }
        return interestEarned;
	}
	
	/**
	toString method
	*/
	
	public String toString()
	{
		return "Account number: "+ getAccountNumber() + "\nAccount balance: " + getBalance() + "\nMinimum balance: " + minBalance;
	}
	
	public static void main(String args[])
	{
		Savings st = new Savings("",0,0);
		System.out.print(st);
	}
	
}