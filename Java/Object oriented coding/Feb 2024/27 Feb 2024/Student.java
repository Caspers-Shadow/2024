public class Student
{
	private String name;
	private String studentNumber;
	
	public Student() //Default constructor
	{
		this("0000000","");
	}
	
	public Student(String sNo,String sName)  //Parametered constructor
	{
		setStudentNumber(sNo);
		setName(sName);
	}
	
	public void setStudentNumber(String sNo) //Mutators
	{
		studentNumber = sNo;
	}
	
	public String getStudentNumber() //Accessor
	{
		return studentNumber;
	}
	
	public void setName (String sName) //Mutators
	{
		name = sName;
	}
	
	public String getName() //Accessor
	{
		return name;
	}
	
	public String toString()
	{
		return "The object is : Student name = " + name + " | Student number = " + studentNumber;
	}
	
	public static void main(String args[])
	{
		Student s1 = new Student();
		System.out.println("Student s1 = " + s1);
		
		s1.setStudentNumber("7654321");
		s1.setName("Hanna Bucks");
		System.out.println("\nLook we changed student number and name!!!!! \n" + s1.getStudentNumber + " AND " + s1.getName + "\n");
		
		Student s2 = new Student("1234567","Les Nesson");
		System.out.println("Student s2 = " + s2);
	}
}