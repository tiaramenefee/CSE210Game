class Program
{
    public static void Main()
    {
        GameManager manager = new GameManager();
        manager.Run();

        SimpleGoal goal1 = new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000);
        EternalGoal goal2 = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
        ChecklistGoal goal3 = new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10, 500);

        
        GoalManager.AddGoal(goal1);
        GoalManager.AddGoal(goal2);
        GoalManager.AddGoal(goal3);

       
        Console.WriteLine("Current Goals:");
        GoalManager.DisplayGoals();

      
        goal1.RecordEvent(); 
        goal2.RecordEvent(); 
        goal3.RecordEvent(); 

        
        Console.WriteLine("\nUpdated Goals:");
        GoalManager.DisplayGoals();

        
        GoalManager.AddPoints(goal1.GetPoints());
        GoalManager.AddPoints(goal2.GetPoints());
        GoalManager.AddPoints(goal3.GetPoints());
        GoalManager.DisplayScore();
    }
    }
}