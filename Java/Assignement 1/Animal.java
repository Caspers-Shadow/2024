/**
Assignment 1
Mariska Adriaanzen
43054226
*/

public abstract class Animal
{
	private String name;
	private String owner;
	private int age;
	
	public Animal()
	{
		this("","",0);
	}
	
	public Animal(String name, String owner, int age)
	{
		this.name = name;
		this.owner = owner;
		this.age = age;
	}
	
	public void setName(String name)
	{
		this.name = name;
	}
	
	public String getName()
	{
		return name;
	}
	
	public void setOwner(String owner)
	{
		this.owner = owner;
	}
	
	public String getOwner()
	{
		return owner;
	}
	
	public void setAge(int age)
	{
		this.age = age;
	}
	
	public int getAge()
	{
		return age;
	}
	
	public abstract String getSound();
	
	public String toString()
	{
		return "Animals name: "+getName()+"\nAnimals age: "+getAge()+"\nOwners name: "+getOwner();
	}
	
	
} 