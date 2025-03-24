/**
@author GR Drevin
@version 20240313
*/
public class RoundThing extends Thing
{
   private int radius;
   
   public RoundThing()
   {
      this("",1);
   }
   
   public RoundThing(String color, int radius)
   {
      super(color);
      setRadius(radius);
   }
   
   public int getRadius()
   {
      return radius;
   }
   
   public void setRadius(int r)
   {
	   if (r > 0)
		   radius=r;
		else
			throw new InvalidRadiusException("Radius of "+ r + " is invalid");
   }
   
   //Uses super classes abstract stuff
   public int calcArea()
   {
	   return (int)((Math.PI)*radius*radius);
   }
      
   public String toString()
   {
      return "I am a "+getColor()+" round thing with radius "+getRadius()+"."; 
   }
  
   public static void main(String[] args) 
   {
	   RoundThing rt1 = new RoundThing();
	   
	   try
	   {
		   rt1 = new RoundThing("Blue",10);
		   System.out.println("That worked");
	   }
	   
	   catch(InvalidRadiusException e)
	   {
		   System.out.println("This was a problem: " + e);
	   }
	   
	   finally
	   {
		   System.out.println("I am in the final block");
	   }
	   
      System.out.println(rt1);
   }
}