
import java.io.*;
import java.util.*;

public class Testing
{
	public static final int MAX_NO_OF_ARRAY = 10;
	
	public static Scanner input;
	public static ObjectOutputStream output;
	
	//====================OUTPUT====================================
	
	public static void openOutput()
	{
		try
		{
			output = new ObjectOutputStream(new FileOutputStream("Accounts.ser"));
			System.out.println("Output file opened");
		}
		catch(IOException ioe)
		{
			System.out.println("Error "+ioe);
			System.exit(1);
		}
	}
	
	public static void closeOutput()
	{
		try
		{
			output.close();
		}
		catch(IOException ioe)
		{
			System.out.println("Could not close "+ ioe);
			System.exit(1);
		}
	}
	
	//====================OUTPUT====================================
	
	//====================INPUT====================================
	
	public static void openInput()
	{
		try
		{
			input = new Scanner(new File("bankdata.txt"));
			input.useDelimiter("[#\\n\\r]");
			System.out.println("File open");
		}
		catch(IOException ioe)
		{
			System.out.println("Could not open file: " + ioe);
			System.exit(1);
		}
	}
	
	public static void closeInput()
	{
		input.close();
		System.out.println("File was closed");
	}
	
	//====================INPUT====================================
	
	//====================APP====================================
	
	public static void application()
	{
		char typeAcc;
		String accNum;
		String name;
		int balance;
		int numObjects = 0;
		
		Account[] stuff = new Account[MAX_NO_OF_ARRAY];
		
		while(input.hasNext())
		{
			typeAcc = input.next().charAt(0);
			accNum = input.next();
			name = input.next();
			balance = input.nextInt();
			
			if(typeAcc == 'C')
			{
				int overLim = input.nextInt();
				stuff[numObjects++] = new Credit(accNum,balance,overLim);
			}
			else if(typeAcc == 'S')
			{
				int minBal = input.nextInt();
				stuff[numObjects++] = new Savings(accNum,balance,minBal);
			}
			else
					System.out.println("Incorrect type = " + typeAcc);
			
		}
		
		for(int i =0; i < numObjects;i++ )
		{
			System.out.println(stuff[i]);
		}
		
		for(int j =0; j < numObjects;j++ )
		{
			try
			{
				output.writeObject(stuff[j]);
			}
			catch(IOException ioe)
			{
				System.out.println("Problem writing object "+ ioe);
				System.exit(1);
			}
			
		}
		
	
	}
	
	//====================APP====================================
	
	public static void main(String[] args)
	{
		openInput();
		openOutput();
		application();
		closeInput();
		closeOutput();
	}
}