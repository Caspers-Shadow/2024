/**
Assignment 1
Mariska Adriaanzen
43054226
*/

public class TestAnimal
{
	public static void main(String[] args)
	{
		System.out.println("====In-Code Input====");
		Cat c1 = new Cat("Ariel","Mariska",'L',11);
		Dog d1 = new Dog("Cola","Divan",5,2);
		System.out.println("\n\nc1: "+c1);
		System.out.println("\nd1: "+d1.toString());
		
		System.out.println("\n\n__With The sound they make:__ ");
		System.out.println("\n\nc1: "+c1+"\nSound a cat makes: " +c1.getSound());
		System.out.println("\nd1: "+d1+"\nSound dogs make: "+d1.getSound());
		
		System.out.println("\n\n====Polymorphism====");
		Animal a1 = new Cat("Casper","Divan",'M',1);
		System.out.println("\n\nca1: "+a1+"\nSound a cat makes: " +a1.getSound());
		
		System.out.println("\n\n====Array of pets====");
		Cat c2= new Cat ("Cloe","Mariska",'S',10);
		Dog d2 = new Dog ("Pluto","Riana",2,10);
		Cat c3= new Cat ("E.T.","Andre",'M',15);
		Dog d3 = new Dog ("Leo","Mariska",3,13);
		Cat c4= new Cat ("Bully","Riana",'M',16);
		Dog d4 = new Dog ("Scooby","Divan",6,1);
		
		Animal pets[] = new Animal[8];
		pets[0] = c1;
		pets[1] = d1;
		pets[2] = c2;
		pets[3] = c3;
		pets[4] = d2;
		pets[5] = c4;
		pets[6] = d3;
		pets[7] = d4;
		for (int i= 0; i<8; i++)
		{
			int num = i+1;
			System.out.println("\nPet number " +num+": "+pets[i]+"\nSound they make: "+pets[i].getSound());
		}
		
		System.out.println("\n\n====Similar values but different addresses====");
		Dog d10= new Dog("Milo","Andre",5,9);
		Dog d20= new Dog("Milo","Andre",5,9);
		if (d10.equals(d20)) 
			System.out.println("\nd10 == d20!!!!!!!!");
		else
			System.out.println("\nWe're good. No issues");
	}
}