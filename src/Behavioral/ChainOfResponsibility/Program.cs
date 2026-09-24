/* Wikipedia
"In object-oriented design, the chain-of-responsibility pattern is a behavioral design 
pattern consisting of a source of command objects and a series of processing objects. Each 
processing object contains logic that defines the types of command objects that it can handle; 
the rest are passed to the next processing object in the chain."
*/
Approver directorApprover   = new Director();
Approver vpApprover         = new VicePresident();
Approver ceoApprover        = new Chief();

directorApprover.SetNext(vpApprover);
vpApprover.SetNext(ceoApprover);

directorApprover.Approve(new ExpenseRequest("Laptop", 800));
Console.WriteLine();
directorApprover.Approve(new ExpenseRequest("Team offsite", 12000));
Console.WriteLine();
directorApprover.Approve(new ExpenseRequest("New office lease", 90000));

/*
When to Use it
Use Chain of Responsibility when more than one object might handle a request, and the handler isn't known in advance.

It's also a good choice when you want to issue a request without specifying the receiver explicitly.

And it's helpful when the set of handlers, and their order, should be configurable rather than hard-coded.
*/