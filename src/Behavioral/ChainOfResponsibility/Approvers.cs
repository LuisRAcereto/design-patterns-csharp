// Concrete handlers, each with its own approval limit
public class Director : Approver
{
    protected override bool CanApprove(ExpenseRequest request) => request.Amount <= 1000;
}

public class VicePresident: Approver
{
    protected override bool CanApprove(ExpenseRequest request) => request.Amount <= 20000;
}

public class Chief : Approver
{
    protected override bool CanApprove(ExpenseRequest request) => request.Amount <= 50000;
}