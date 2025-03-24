
import java.io.*;
import java.util.*;

public class Testing
{
	public static final int MAX_NO_OF_ARRAY = 10;
	
	public static Scanner input;
	public static ObjectOutputStream output;
	
	//====================INPUT====================================
	
	public static void openInput()
	{
		try
		{
			input = new Scanner(new File("Accounts.ser"));
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
		Account record;
		int totalODL = 0;
		
		try
		{
			while(true)
			{
				record = (Account)input.readObject();
				System.out.println(record);
				
				if(record instanceof Credit)
				{
					totalODL += ((Credit)record).getOverdraftLimit();
				}
			}
		}
		//Catch's should be from small to big
		catch(EOFException e)
		{
			System.out.println("EOF Reached "+ e);
			System.out.println("The total overdraft limit of all Credit accounts is: "+ totalODL);
		}
		catch(IOException ioe)
		{
			System.out.println("Error Reading " + ioe);
			System.exit(1);
		}
		catch(Exception ei)
		{
			System.out.println("BIG error " + ei);
			System.exit(1);
		}
	}
	
	//====================APP====================================
	
	public static void main(String[] args)
	{
		openInput();
		application();
		closeInput();
	}
}