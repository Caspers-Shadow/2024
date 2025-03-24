public class TestCode
{
	public static void main(String args[])
	{
		Person sPeople = new Person();
		
		
		System.out.println("================STUDENT===============\n\n");
		
		Student s1 = new Student();
		System.out.println("Student class set with no values: \n" + s1 + sPeople);
		
		sPeople.setID("43054226");
		sPeople.setName("Mariska Adriaanzen");
		sPeople.setEmail("mariska@adriaanzen.co.za");
		s1.setStatus("BACHELORS");
		System.out.println("\nHere are some values: \n" + s1 + sPeople + "\n");
		
		
		Employee sEmp = new Employee();
		
		
		System.out.println("================FACULTY===============\n\n");
		
		Faculty s2 = new Faculty();
		System.out.println("Faculty class set with no values: \n" + sPeople + s2 + sEmp);
		
		sPeople.setID("54226430");
		sPeople.setName("Conrad Du Toit");
		s2.setRank("CEO");
		sEmp.setOffice("G4 211");
		sPeople.setEmail("Conrad@gmail.co.za");
		
		System.out.println("\nHere are some values: \n" + s2 + sPeople + sEmp + "\n");
		
		/**
		System.out.println("================STAFF===============\n\n");
		
		Staff s3 = new Staff();
		System.out.println("Staff class set with no values: \n" + s3);
		
		s1.setID("22654430");
		s1.setName("Dylan Oelofse");
		s1.setTitle("Mr.");
		s1.setOffice("G1 111");
		s1.setEmail("dylan.oelofse@yahoo.co.za");
		
		System.out.println("\nHere are some values: \n" + s1 + "\n");
		
		*/
	}
}