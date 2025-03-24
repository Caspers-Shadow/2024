public class TestStudent
{
	public static void main(String args[])
	{
		System.out.println("================STUDENT===============\n\n");
		
		Student s1 = new Student();
		System.out.println("Student class set with no values: \n" + s1);
		
		s1.setID("43054226");
		s1.setName("Mariska Adriaanzen");
		s1.setEmail("mariska@adriaanzen.co.za");
		s1.setStatus("BACHELORS");
		System.out.println("\nHere are some values: \n" + s1 + "\n");
		
	}
}