import java.util.Arrays;

public class TestAccountsArray
{
	
	public static void main(String[] args) 
	{
		Account acs[] = new Account[20];
		
		acs[0] = new Savings("12345679",500,450);
		acs[1] = new Credit("12345660",-500,-10000);
		acs[2] = new Credit("34567860",5500,-1100);
		acs[3] = new Savings("45679010",2500,420);
		acs[4] = new Savings("32145675",1500,470);
		acs[5] = new Credit("61325678",-5310,-20000);
		acs[6] = new Credit("54567874",670,-41000);
		
		for(int i = 0; i < acs.length; i++)
		{
			System.out.println(acs[i]);
		}
		
		System.out.println("\n=====================After sorting===================== ");
	//	Arrays.sort(acs,0,7);
	
		Account[] temp = Arrays.copyOf(acs,7);
		acs = temp;
		Arrays.sort(acs);
		
		for(int i = 0; i < acs.length; i++)
		{
			System.out.println(acs[i]);
		}
	}
}