public class TestingMin 
{
    public static void main(String args[]) 
	{
        MyLinkedList<Integer> numbers = new MyLinkedList<>();

        // Testing the getMin() method when filling the num,bers list with content
		//and should give us an answer of 3
        numbers.append(16);
        numbers.append(44);
        numbers.append(7);
        numbers.append(45);
        numbers.append(3);
		
        Integer min = numbers.getMin();
        System.out.println("Minimum value in the list: " + min); 

        // Test with a single element list with an expected answer of 66
        MyLinkedList<Integer> oneNumber = new MyLinkedList<>();
        oneNumber.append(66);
        min = oneNumber.getMin();
        System.out.println("Minimum value in the list with only one element: " + min); 

        // Test with an empty list with the answer given as null
        MyLinkedList<Integer> nada = new MyLinkedList<>();
        min = nada.getMin();
        System.out.println("Minimum value in the empty list: " + min);
    }
}