/* Wikipedia definition:
"The composite pattern describes a group of objects that are treated the same way as a single instance of the same type of object. 
The intent of a composite is to compose objects into tree structures to represent part-whole hierarchies."
*/

// Individual employees
var ceo         = new Employee("Alice (CEO)",       120_000);
var cto         = new Employee("Bob (CTO)",          95_000);
var dev1        = new Employee("Carol (Developer)",  65_000);
var dev2        = new Employee("David (Developer)",  62_000);
var cfo         = new Employee("Eve (CFO)",          90_000);
var accountant  = new Employee("Frank (Accountant)", 55_000);

// Build the Engineering department
var engineering = new Department("Engineering");
engineering.Add(cto);
engineering.Add(dev1);
engineering.Add(dev2);

// Build the Finanace department
var finance = new Department("Finance");
finance.Add(cfo);
finance.Add(accountant);

// Build the whole company
var company = new Department("Acme Corp");
company.Add(ceo);
company.Add(engineering);
company.Add(finance);

// Ask the whole company - one call, rolls up everything
Console.WriteLine("=== Full Company ===");
company.GetDetails();

//Ask just one department - same call, same interface
Console.WriteLine("\n=== Engineering === ");
engineering.GetDetails();

//Ask a single employee - same call, same interface
Console.WriteLine("\n=== Single Employee ===");
dev1.GetDetails();
