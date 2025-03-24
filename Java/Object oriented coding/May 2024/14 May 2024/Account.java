/**
@author GR Drevin
@version 20240514
*/

import java.io.*;
import java.util.*;

public abstract class Account implements Interest, Serializable, Comparable<Account>
{
	private String accountNumber;
	private int balance;
	private String dataInfo;
	
	public Account()
	{
		this("0000000000",0);
	}
	
	public Account(String accountNumber, int balance)
	{
		setAccountNumber(accountNumber);
		setBalance(balance);
	}
	
	public void setAccountNumber(String accountNumber)
	{	int sum = 0;
		if(accountNumber.length()!=8)
			throw new InvalidAccountNumberException("Length of number is invalid. Length = "+accountNumber.length());
		for (int i = 0; i<8; i++)
		{
			sum += (accountNumber.charAt(i)-'0') * (8-i);
			
		}
		if (sum % 11 == 0)
			this.accountNumber = accountNumber;
		else
			throw new InvalidAccountNumberException("Checksum error with account number = "+accountNumber);
	}
	
	public int compareTo(Account other)
	{
		String thisField = this.getAccountNumber();
		String otherField = other.getAccountNumber();
		return thisField.compareTo(otherField);
	}
	
	public void setBalance(int balance)
	{
		this.balance = balance;
	}
	
	public String getAccountNumber()
	{
		return accountNumber;
	}
	
	public int getBalance()
	{
		return balance;
	}
	
	public String toString()
	{
		return "Account no: "+getAccountNumber()+" has balance of "+getBalance();
	}
}