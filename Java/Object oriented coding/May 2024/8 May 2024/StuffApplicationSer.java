import java.io.*;
import java.util.*;

public class StuffApplicationSer
{
	//Constants
	public static final int MAX_NO_OF_THINGS = 10;
		public static Scanner input;
	public static ObjectOutputStream output; //Turns into a stream of bites
	
	public static void openOutput()
	{
		try
		{
			output = new ObjectOutputStream(new FileOutputStream("stuff.ser"));
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
	
	//Read out of a file
	public static void openInput()
	{
		try
		{
			input = new Scanner(new File("stuff.txt"));
			System.out.println("File open");
		}
		catch(IOException ioe)
		{
			System.out.println("Could not open file: " + ioe);
			System.exit(1);
		}
	}
	
	//Close the file
	public static void closeInput()
	{
		input.close();
		System.out.println("File was closed");
	}
	
	//What should be done with the text
	public static void application()
	{
		char type;
		String colour;
		int radius, width, length;
		int numObjects = 0;
		
		Thing[] stuff = new Thing[MAX_NO_OF_THINGS];
		
		while(input.hasNext())
		{
			type = input.next().charAt(0);
			colour = input.next();
			//System.out.println("Type: "+type+", Colour: "+colour);
			
			if(type == 'C')
			{
				radius = input.nextInt();
				stuff[numObjects++] = new RoundThing(colour,radius);
			}
			else if(type == 'R')
			{
				length = input.nextInt();
				width = input.nextInt();
				stuff[numObjects++] = new RectangularThing(colour,length,width);
			}
			else if(type == 'S')
			{
				length = input.nextInt();
				stuff[numObjects++] = new SquareThing(colour,length);
			}
			else
				System.out.println("Incorrect type = " + type);
		}
		
		for(int i =0; i < MAX_NO_OF_THINGS;i++ )
		{
			System.out.println(stuff[i]);
		}
		
		for(int i =0; i < numObjects;i++ )
		{
			try
			{
				output.writeObject(stuff[i]);
			}
			catch(IOException ioe)
			{
				System.out.println("Problem writing object "+ ioe);
				System.exit(1);
			}
			
		}
	}
	
	public static void main(String[] args)
	{
		openInput();
		openOutput();
		application();
		closeInput();
		closeOutput();
	}
	
}
