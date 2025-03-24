/**
Mariska Adriaanzen
43054226
Practical 5
*/

public class StackAsMyLinkedList<E> 
{
    private MyLinkedList<E> stack = new MyLinkedList<>();
    
    public void push(E item) 
	{
        stack.prepend(item);
    }
    
    public E pop() 
	{
        return stack.removeFirst();
    }
    
    public int size() 
	{
        MyLinkedList<E> tempStack = new MyLinkedList<>();
        int size = 0;
        E kop = stack.removeFirst();

        while (kop != null) 
		{
            tempStack.append(kop);
            kop = stack.removeFirst();
            size++;
        }

        while (tempStack.getFirst() != null) 
		{
            stack.prepend(tempStack.removeFirst());
        }

        return size;
    }
    
    public boolean isEmpty() 
	{
		if(stack.getFirst() != null)
		{
			return true;
		}
		else
		{
			return false;
		}
    }
    
    public String toString() 
	{
        return stack.toString();
    }
}
