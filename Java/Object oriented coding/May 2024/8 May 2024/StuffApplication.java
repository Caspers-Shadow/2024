import java.io.*;
import java.util.*;

public class StuffApplication
{
	//Constants
	public static final int MAX_NO_OF_THINGS = 10;
	
	public static Scanner input;
	
	//Read out of a file
	public static void openInput()
	{
		try
		{
			input = new Scanner(new File("stuff2.txt"));
			input.useDelimiter("[,\\n\\r]");
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
		
		System.out.println("Only round things: ");
		
		for(int i =0; i < numObjects;i++ )
		{
			if(stuff[i] instanceof RoundThing)
			{
				System.out.println(stuff[i]);
			}
			
		}
	}
	
	public static void main(String[] args)
	{
		openInput();
		application();
		closeInput();
	}
	
}
