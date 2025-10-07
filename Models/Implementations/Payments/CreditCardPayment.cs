using examen_software_Romero_Mariño.Models.Interfaces;

namespace examen_software_Romero_Mariño.Models.Implementations.Payments;

public class CreditCardPayment : IPayment
{
    public bool ProcessPayment(decimal amount, string user)
    {
        Console.WriteLine("Procesando pago con tarjeta de crédito...");
        Console.WriteLine($"   Usuario: {user}");
        Console.WriteLine($"   Monto: ${amount:F2}");
        
        // Simulacion de procesamiento
        Console.WriteLine("   Validando tarjeta...");
        Console.WriteLine("   Autorizando transacción...");
        
        bool success = amount > 0; // Simulacion simple
        
        if (success)
        {
            Console.WriteLine("--Pago procesado exitosamente con tarjeta");
        }
        else
        {
            Console.WriteLine("--Error en el procesamiento del pago con tarjeta");
        }
        
        Console.WriteLine();
        return success;
    }
}