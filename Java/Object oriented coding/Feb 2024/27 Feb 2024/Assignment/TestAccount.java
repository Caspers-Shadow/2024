//Assignment 1
//43054226 : Mariska Adriaanzen

public class TestAccount
{
	public static void main(String args[])
	{
		Account sClean = new Account();//Inpto default constructor
		System.out.println("Account as a 'clean' program : \n" + sClean);
		
		sClean.setAccNumber("008765"); //into mutators
		sClean.setBalance(200);
		System.out.println("\n\nHeres a bit of values:\n" + sClean + "\n");
		
		Account sHard = new Account("12579",7824);//Hardcoded into constructor
		System.out.println("Lastly we manaully put some values in the main function and we get:\n" + sHard);
	}
}