using examen_software_Romero_Mariño.Models.Implementations.Payments;
using examen_software_Romero_Mariño.Models.Implementations.Notifiers;
using examen_software_Romero_Mariño.Services;

namespace examen_software_Romero_Mariño;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SISTEMA DE PROCESAMIENTO DE PAGOS ROMERO MARIÑO");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        // Datos inicializados internamente
        var transactions = new[]
        {
            new { User = "Juan Pérez", Amount = 150.75m, Description = "Compra de productos electrónicos" },
            new { User = "María García", Amount = 89.99m, Description = "Suscripción mensual premium" },
            new { User = "Carlos López", Amount = 5000.00m, Description = "Pago de servicios profesionales" },
            new { User = "Ana Martínez", Amount = 25.50m, Description = "Compra de libros digitales" },
            new { User = "Pedro Rodríguez", Amount = 15000.00m, Description = "Pago excesivo para probar límites" }
        };

        Console.WriteLine("Procesando transacciones...");
        Console.WriteLine();

        // Ejemplos de procesamiento con diferentes combinaciones
        Console.WriteLine("--- TRANSACCIÓN 1: Tarjeta + Correo ---");
        var creditCardPayment = new CreditCardPayment();
        var emailNotifier = new EmailNotifier();
        var processor1 = new PaymentProcessor(creditCardPayment, emailNotifier);
        processor1.ProcessTransaction(transactions[0].Amount, transactions[0].User, transactions[0].Description);

        Console.WriteLine("--- TRANSACCIÓN 2: Transferencia + SMS ---");
        var bankTransferPayment = new BankTransferPayment();
        var smsNotifier = new SmsNotifier();
        var processor2 = new PaymentProcessor(bankTransferPayment, smsNotifier);
        processor2.ProcessTransaction(transactions[1].Amount, transactions[1].User, transactions[1].Description);

        Console.WriteLine("--- TRANSACCIÓN 3: Transferencia + Correo ---");
        var processor3 = new PaymentProcessor(bankTransferPayment, emailNotifier);
        processor3.ProcessTransaction(transactions[2].Amount, transactions[2].User, transactions[2].Description);

        Console.WriteLine("--- TRANSACCIÓN 4: Tarjeta + SMS ---");
        var processor4 = new PaymentProcessor(creditCardPayment, smsNotifier);
        processor4.ProcessTransaction(transactions[3].Amount, transactions[3].User, transactions[3].Description);

        Console.WriteLine("--- TRANSACCIÓN 5: Transferencia con monto excesivo (fallará) ---");
        var processor5 = new PaymentProcessor(bankTransferPayment, emailNotifier);
        processor5.ProcessTransaction(transactions[4].Amount, transactions[4].User, transactions[4].Description);

        Console.WriteLine("==============================================");

        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
