// The concrete workers
public class Developer : IWorker
{
    public void DoWork() => Console.WriteLine("Developer: Writing code.");
}

public class Designer : IWorker
{
    public void DoWork() => Console.WriteLine("Designer: Creating designs.");
}
