/*
"In object-oriented programming, the factory method pattern is a design pattern that uses factory methods to deal with the problem 
of creating objects without having to specify their exact classes. 
Factory methods can be specified in an interface and implemented by subclasses, or implemented in a base class and optionally 
overridden by subclasses."
*/

// Company A needs a tech worker
RecruitmentAgency agency = new TechAgency();
IWorker worker = agency.HireWorker();
worker.DoWork();

// Company B needs a design worker
RecruitmentAgency agency2 = new DesignAgency();
IWorker worker2 = agency2.HireWorker();
worker2.DoWork();