// Company A needs a tech worker
RecruitmentAgency agency = new TechAgency();
IWorker worker = agency.HireWorker();
worker.DoWork();

// Company B needs a design worker
RecruitmentAgency agency2 = new DesignAgency();
IWorker worker2 = agency2.HireWorker();
worker2.DoWork();