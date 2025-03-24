public class TestFaculty
{
	public static void main(String args[])
	{
		System.out.println("================FACULTY===============\n\n");
		
		Faculty s1 = new Faculty();
		System.out.println("Faculty class set with no values: \n" + s1);
		
		s1.setID("54226430");
		s1.setName("Conrad Du Toit");
		s1.setRank("CEO");
		s1.setOffice("G4 211");
		s1.setEmail("Conrad@gmail.co.za");
		
		System.out.println("\nHere are some values: \n" + s1 + "\n");
	}
}