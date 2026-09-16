public class OrchestraCondutor
{
    // Step 1: Hold the one instance here
    private static OrchestraCondutor? _instance;

    // Step 2: Private constructor - nobody outside can do: new OrchestraCondutor()
    private OrchestraCondutor() {}

    // Step 3: The only way to get the conductor
    public static OrchestraCondutor GetInstance()
    {
        if (_instance == null)
        {
            _instance = new OrchestraCondutor();
        }

        return _instance;
    }

    // Decisions the conductor makes
    public void Start()                 => Console.WriteLine("Conductor: Begin Playing.");
    public void Stop()                  => Console.WriteLine("Conductor: Stop Playing.");
    public void SetTempo(string tempo)  => Console.WriteLine($"Conductor: Tempo is now {tempo}");
}