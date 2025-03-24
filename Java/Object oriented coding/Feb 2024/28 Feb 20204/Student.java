/**
This class manages info on students.
@author M Adriaanzen
@version 20240228
*/
public class Student
{
	private String name;
	private String studentNumber;
	
	/**
	Constructor sets the instance variable to default values
	*/
	
	//---------------------Constructors-----------------------------------------
	public Student() //Default constructor
	{
		this("0000000","");
	}
	
	/**
	Constructor recieves paramaters for instance variables and sets instance variables
	@parm student university number of student
	@parm name of the students
	*/
	
	public Student(String studentNumber,String name)  //Parametered constructor
	{
		setStudentNumber(studentNumber);
		setName(name);
	}
	
	
	//----------------------Student number----------------------------------------
	public void setStudentNumber(String studentNumber) //Mutators
	{
		this.studentNumber = studentNumber;//this. is the private one
	}
	
	public String getStudentNumber() //Accessor
	{
		return studentNumber;
	}
	
	////----------------------Student name-----------------------------------------
	public void setName (String name) //Mutators
	{
		this.name = name;
	}
	
	/**
	Returns the value of the instance variable name
	@parm name of the students
	*/
	
	public String getName() //Accessor
	{
		return name;
	}
	
	//-----------------------toString------------------------------------------------
	public String toString()
	{
		return "The object is : Student name = " + name + " | Student number = " + studentNumber;
	}
}