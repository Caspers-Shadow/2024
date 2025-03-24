/**
Assignment 1
Mariska Adriaanzen
43054226
*/

public class Cat extends Animal
{
	private char fluff;
	
	public Cat()
	{
		this("","",' ',0);
	}
	
	public Cat(String name, String owner, char fluff, int age)
	{
		super(name,owner,age);
		this.fluff = fluff;
	}
	
	public void setFluff(char fluff)
	{
		this.fluff = fluff;
	}
	
	public char getFluff()
	{
		return fluff;
	}
	
	public String getSound()
	{
		return "Meow";
	}
	
	public String toString()
	{
		return super.toString()+"\nThe amount of fluff this cats has [S(short), M(medium) or L(long)]: "+getFluff();
	}
}