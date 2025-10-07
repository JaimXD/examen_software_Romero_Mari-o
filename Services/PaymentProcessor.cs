using examen_software_Romero_Mariño.Models.Interfaces;

namespace examen_software_Romero_Mariño.Services;

public class PaymentProcessor
{
    private readonly IPayment _paymentMethod;
    private readonly INotifier _notifier;

    // Constructor con inyección de dependencias
    public PaymentProcessor(IPayment paymentMethod, INotifier notifier)
    {
        _paymentMethod = paymentMethod ?? throw new ArgumentNullException(nameof(paymentMethod));
        _notifier = notifier ?? throw new ArgumentNullException(nameof(notifier));
    }

    public void ProcessTransaction(decimal amount, string user, string description)
    {
        Console.WriteLine("=== INICIANDO PROCESAMIENTO DE TRANSACCIÓN ===");
        Console.WriteLine($"Descripción: {description}");
        Console.WriteLine();

        // Procesar el pago usando el método inyectado
        bool paymentSuccess = _paymentMethod.ProcessPayment(amount, user);

        // Determinar el mensaje de notificación
        string message;
        if (paymentSuccess)
        {
            message = $"Su pago de ${amount:F2} ha sido procesado exitosamente. Descripción: {description}";
        }
        else
        {
            message = $"Su pago de ${amount:F2} no pudo ser procesado. Descripción: {description}. Por favor, intente nuevamente.";
        }

        // Enviar notificación usando el notificador inyectado
        _notifier.SendNotification(user, message);

        Console.WriteLine("=== TRANSACCIÓN COMPLETADA ===");
        Console.WriteLine();
    }
}