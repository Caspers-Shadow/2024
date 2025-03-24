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
		
		int j = 8;
		int sum = 0;
		int finalMod = 0;
		for (int i = 0; i < lengte; i++) 
		{
			digitArray[i] = Character.getNumericValue(num.charAt(i));			   
			sum = sum + (digitArray[i] * j);			
			j--;
		}
			
		finalMod = sum %11;
		
		if (lengte == 8 && finalMod == 0)
		{
			accNum = num;		
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
		Account rt1 = new Credit();
	   
	   try
	   {
		   rt1 = new Credit("43054226",0,0);
		   System.out.println("That worked for Credit");
	   }
	   
	   catch(InvalidAccountNumber s)
	   {
		   System.out.println("This was a problem in Credit: " + s);
	   }
	   
      System.out.println(rt1);
	  
	  Account rt2 = new Savings();
	   
	   try
	   {
		   rt2 = new Savings("43054226",0,0);
		   System.out.println("That worked for Savings");
	   }
	   
	   catch(InvalidAccountNumber s)
	   {
		   System.out.println("This was a problem in Savings: " + s);
	   }
	   
      System.out.println(rt2);
	  
	}
	
}