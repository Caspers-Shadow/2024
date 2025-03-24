public class SquareThing extends Thing 
{
	private int length;
	
	public SquareThing()
	{}
	
	public SquareThing(String color, int length)
	{
		super(color);
		setLength(length);
	}
	
	public void setLength(int length)
	{
		this.length = length;
	}
	
	public int getLength()
	{
		return length;
	}
	
	public double calculateArea()
	{
		return Math.pow(getLength(),2);
	}
	
	public String toString()
	{
		return "I am a "+getColor()+" Square thing with sides "+getLength()+" and area "+calculateArea();
	}
	
	public static void main(String[] args) 
	{
		SquareThing square1 = new SquareThing("Red",5);
		System.out.println(square1);
	}	
}