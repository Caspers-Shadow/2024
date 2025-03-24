/**
Assignment 1
Mariska Adriaanzen
43054226
*/

public class Dog extends Animal
{
	private int exercise;
	
	public Dog()
	{
		this("","",0,0);
	}
	
	public Dog(String name, String owner, int exercise, int age)
	{
		super(name,owner,age);
		this.exercise = exercise;
	}
	
	public void setExercise(int exercise)
	{
		this.exercise = exercise;
	}
	
	public int getExercise()
	{
		return exercise;
	}
	
	public String getSound()
	{
		return "Woof";
	}
	
	public boolean equals(Dog dog)
	{
		return this.exercise == dog.getExercise();
	}
	
	public String toString()
	{
		return super.toString()+"\nHow long the dog must exercise per day (in hours): "+getExercise();
	}
}