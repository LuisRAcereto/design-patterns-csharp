// The base agency - declares the factory method
public abstract class RecruitmentAgency
{
    // This is the factory Methodd - subclasses decide who to hire
    public abstract IWorker HireWorker();
}

// Concrete agencies - each one decides which worker to send
public class TechAgency : RecruitmentAgency
{
    public override IWorker HireWorker() => new Developer();
}

public class DesignAgency : RecruitmentAgency
{
    public override IWorker HireWorker() => new Designer();
}