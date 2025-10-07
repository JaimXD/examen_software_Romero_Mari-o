using examen_software_Romero_Mariño.Models.Interfaces;

namespace examen_software_Romero_Mariño.Models.Implementations.Notifiers;

public class EmailNotifier : INotifier
{
    public void SendNotification(string user, string message)
    {
        Console.WriteLine($"Enviando correo electrónico a {user}:");
        Console.WriteLine($"   Mensaje: {message}");
        Console.WriteLine($"   Estado: Correo enviado exitosamente");
        Console.WriteLine();
    }
}