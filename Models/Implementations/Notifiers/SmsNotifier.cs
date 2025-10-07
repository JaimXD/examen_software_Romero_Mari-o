using examen_software_Romero_Mariño.Models.Interfaces;

namespace examen_software_Romero_Mariño.Models.Implementations.Notifiers;

public class SmsNotifier : INotifier
{
    public void SendNotification(string user, string message)
    {
        Console.WriteLine($"Enviando SMS a {user}:");
        Console.WriteLine($"   Mensaje: {message}");
        Console.WriteLine($"   Estado: SMS enviado exitosamente");
        Console.WriteLine();
    }
}