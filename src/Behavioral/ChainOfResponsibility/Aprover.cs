// The handler, every link in the chain implement this
public abstract class Approver
{
    private Approver? _next;

    public void SetNext(Approver next) => _next = next;

    public void Approve(ExpenseRequest request)
    {
        if (CanApprove(request))
        {
            Console.WriteLine($"{GetType().Name}: Approved '{request.Description}' (${request.Amount}).");
        } 
        else if (_next is not null)
        {
            Console.WriteLine($"{GetType().Name}: Can't approve '{request.Description}' (${request.Amount}). Passing it up.");
            _next.Approve(request);
        }
        else
        {
            Console.WriteLine($"{GetType().Name}: No one left to approve '{request.Description}' (${request.Amount}). Request denied.");
        }
    }

    protected abstract bool CanApprove(ExpenseRequest request);
}