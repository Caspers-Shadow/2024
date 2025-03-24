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
		int lengte = num.length(); 
		int[] digitArray = new int[lengte];
		
		if (lengte == 8)
		{
			accNum = num;
			
			int j = 8;
			int sum = 0;
			for (int i = 0; i < lengte; i++) 
			{
            digitsArray[i] = Character.getNumericValue(num.charAt(i));
			sum = sum + (digitArray[i] * j);
			j--;
			}
		}		
		else
			throw new InvalidAccountNumber();
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
	
	public static void main(String args[])
	{
		/** Account rt1 = new Account();
	   
	   try
	   {
		   rt1 = new Account("1000000000",0);
		   System.out.println("That worked");
	   }
	   
	   catch(InvalidAccountNumber e)
	   {
		   System.out.println("This was a problem: " + e);
	   }
	   
	   finally
	   {
		   System.out.println("I am in the final block");
	   }
	   
      System.out.println(rt1);*/
	  
	}
	
}