public class Credit extends Account
{
	private int overLimit;
	
	/**
	Constructors
	*/
	
	public Credit()
	{
		this("00000000",0,0);
		
	}
	
	public Credit(String num, int balance, int limit)
	{
		super(num,balance);
		setOverdraftLimit(limit);
	}
	
	/**
	Setting- and getting the account numbers
	*/
	
	public void setOverdraftLimit(int limit)
	{
		overLimit = limit;
	}
	
	public int getOverdraftLimit()
	{
		return overLimit;
	}
	
	//ABSTRACT CLASS METHOD
	
	public int calculateInterest(int interestRate)
	{
		int interest = 0;
		int calcBalance = getBalance();
		
        if (calcBalance < 0) 
		{
            if (calcBalance < overLimit) {
                interest = calcBalance * 4 * interestRate / 100;
            } 
			else 
			{
                interest = calcBalance * 2 * interestRate / 100;
            }
        } 
		else 
		{
            interest = calcBalance * interestRate / 100;
        }
        return interest;
	}
	
	/**
	toString method
	*/
	
	public String toString()
	{
		return "Account number: "+ getAccountNumber() + " and Account balance: " + getBalance() + " and Overdraft limit: " + overLimit;
	}
	
	public static void main(String args[])
	{
		Credit cr = new Credit("",0,0);
		System.out.print(cr);
	}
}