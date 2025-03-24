/**
Mariska Adriaanzen
43054226
Practical 5
*/

public class QueueAsMyLinkedList<E> 
{
    private MyLinkedList<E> queue = new MyLinkedList<>();
    
    public void enqueue(E item) 
	{
        queue.append(item);
    }
    
    public E dequeue() 
	{
        return queue.removeFirst();
    }
    
    public int size() 
	{
        MyLinkedList<E> tempStack = new MyLinkedList<>();
        int size = 0;
        E kop = queue.removeFirst();

        while (kop != null) 
		{
            tempStack.append(kop);
            kop = queue.removeFirst();
            size++;
        }

        while (tempStack.getFirst() != null) 
		{
            queue.prepend(tempStack.removeFirst());
        }

        return size;
    }
    
    public boolean isEmpty() 
	{
		if(queue.getFirst() != null)
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
        return queue.toString();
    }
}
