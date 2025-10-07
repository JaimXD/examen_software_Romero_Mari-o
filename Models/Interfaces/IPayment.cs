namespace examen_software_Romero_Mariño.Models.Interfaces;

public interface IPayment
{
    bool ProcessPayment(decimal amount, string user);
}