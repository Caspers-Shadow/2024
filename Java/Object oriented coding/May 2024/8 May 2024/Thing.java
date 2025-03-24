import java.io.*;

public abstract class Thing implements Comparable<Thing>, Serializable
{

	private String color;
		
	public Thing()
	{}
	
	public Thing(String color)
	{
		setColor(color);
	}

	public abstract double calculateArea();
	
	public void setColor(String color)
	{
		this.color = color;
	}
	
	public String getColor()
	{
		return color;
	}
	
	public int compareTo(Thing other)
	{
		String thisField = String.format("%-8s&7.2f",this.getColor(),this.calculateArea());
		String otherField = String.format("%-8s&7.2f",other.getColor(),other.calculateArea());
		return thisField.compareTo(otherField);
	}
	
	
	public String toString()
	{
		return "I am a "+getColor()+" thing";
	}
	
	public static void main(String[] args) 
	{
		
	}
}