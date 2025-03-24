public class TestStaff
{
	public static void main(String args[])
	{
		System.out.println("================STAFF===============\n\n");
		
		Staff s1 = new Staff();
		System.out.println("Staff class set with no values: \n" + s1);
		
		s1.setID("22654430");
		s1.setName("Dylan Oelofse");
		s1.setTitle("Mr.");
		s1.setOffice("G1 111");
		s1.setEmail("dylan.oelofse@yahoo.co.za");
		
		System.out.println("\nHere are some values: \n" + s1 + "\n");
	}
}