public class TestStudent
{
	public static void main(String args[])
	{
		Student s1 = new Student();
		System.out.println("Student s1 = " + s1);
		
		s1.setStudentNumber("7654321");
		s1.setName("Hanna Bucks");
		System.out.println("\nLook we changed student number and name!!!!! \n" + s1 + "\n");
		
		Student s2 = new Student("1234567","Les Nesson");
		System.out.println("Student s2 = " + s2);
	}
}