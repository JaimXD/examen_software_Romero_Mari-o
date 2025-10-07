using examen_software_Romero_Mariño.Models.Interfaces;

namespace examen_software_Romero_Mariño.Models.Implementations.Payments;

public class BankTransferPayment : IPayment
{
    public bool ProcessPayment(decimal amount, string user)
    {
        Console.WriteLine("Procesando pago por transferencia bancaria...");
        Console.WriteLine($"   Usuario: {user}");
        Console.WriteLine($"   Monto: ${amount:F2}");
        
        // Simulacion de procesamiento
        Console.WriteLine("   Verificando cuenta bancaria...");
        Console.WriteLine("   Iniciando transferencia...");
        
        bool success = amount > 0 && amount <= 10000; // Simulacion simple
        
        if (success)
        {
            Console.WriteLine("--Transferencia completada exitosamente");
        }
        else
        {
            Console.WriteLine("--Error en la transferencia bancaria");
        }
        
        Console.WriteLine();
        return success;
    }
}