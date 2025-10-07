namespace examen_software_Romero_Mariño.Models.Interfaces;

public interface INotifier
{
    void SendNotification(string user, string message);
}