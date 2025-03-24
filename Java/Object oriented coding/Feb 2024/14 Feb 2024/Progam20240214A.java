import java.util.Scanner;

public class Progam20240214A
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		
		System.out.print("Please enter your name: ");
		String name = input.nextLine();
		
		System.out.println("Welcome to Cmpg211 " + name);
		System.out.printf("I hope you will enjoy it, %s\n",name);
	}
}