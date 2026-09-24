// Subsystem 4: sends the confirmation email
public class EmailService
{
    public void SendConfirmation(string email, string trackingCode)
    {
        Console.WriteLine($"Email: Confirmation sent to {email}. Tracking code: {trackingCode}.");
    }
}