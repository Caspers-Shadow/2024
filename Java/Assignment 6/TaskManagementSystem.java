/**
Mariska Adriaanzen
43054226
Practical 5
*/

public class TaskManagementSystem 
{
    private QueueAsMyLinkedList<String> tou = new QueueAsMyLinkedList<>();
    private StackAsMyLinkedList<String> stapel = new StackAsMyLinkedList<>();
    
    public void addTask(String task) 
	{
        tou.enqueue(task);
    }
    
    public void processNextTask() 
	{
        if (!tou.isEmpty()) 
		{
            String pushToStack = tou.dequeue();
            stapel.push(pushToStack);
            System.out.println("Removed task rom queue (and pushed to stack): " + pushToStack);
        } 
		else 
		{
            System.out.println("There's nothing to process");
        }
    }
    
    public void undoLastTask() 
	{
        if (!stapel.isEmpty()) 
		{
            String fout = stapel.pop();
            tou.enqueue(fout);
            System.out.println("Foutjie wat begaan is: " + fout);
        } 
		else 
		{
            System.out.println("Daar was geen foutjies nie :D");
        }
    }
    
    public void displayStatus() 
	{
        System.out.println("\nWat aangaan in die queue: " + tou);
        System.out.println("Wat aangaan in die Stack: " + stapel +"\n");
    }
}
