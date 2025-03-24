public class RoundThing extends Thing
{
	private int radius;
	
	public RoundThing()
	{}
	
	public RoundThing(String color, int radius)
	{
		super(color);
		setRadius(radius);
	}
		
	public void setRadius(int radius)
	{
//		if (radius > 0)
			this.radius = radius;
//		else
//			throw new InvalidRadiusException("Radius should be greater than 0");
	}
	
	public int getRadius()
	{
		return radius;
	}
	
	public double calculateArea()
	{
		return Math.round(Math.PI * Math.pow(getRadius(),2)*100)/100.0;
	}
	
	public String toString()
	{
		return "I am a "+getColor()+" round thing with radius "+getRadius()+" and area "+calculateArea();
	}
	
	public static void main(String[] args) 
	{
		RoundThing round1 = new RoundThing("Red",5);
		System.out.println(round1);
	}
}