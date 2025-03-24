/**
Mariska Adriaanzen
43054226
Practical 5
*/

public class TaskManagementSystemTest 
{
    public static void main(String[] args) 
	{
        TaskManagementSystem taskManager = new TaskManagementSystem();
        
        taskManager.addTask("hier is die eerste ding");
        taskManager.addTask("ding 2");
        taskManager.addTask("3rd times the charm");
        
        taskManager.displayStatus();
        
        taskManager.processNextTask();
        taskManager.processNextTask();
        
        taskManager.displayStatus();
        
        taskManager.undoLastTask();
        
        taskManager.displayStatus();
    }
}
