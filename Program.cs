using examen_software_Romero_Mariño.Modelos.Implementaciones.Pagos;
using examen_software_Romero_Mariño.Modelos.Implementaciones.Notificadores;
using examen_software_Romero_Mariño.Modelos.Interfaces;
using examen_software_Romero_Mariño.Servicios;

namespace examen_software_Romero_Mariño;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🏪 SISTEMA DE PROCESAMIENTO DE PAGOS ROMA 🏪");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        // Datos inicializados internamente (no ingresados por consola)
        var transacciones = new[]
        {
            new { Usuario = "Juan Pérez", Monto = 150.75m, Descripcion = "Compra de productos electrónicos" },
            new { Usuario = "María García", Monto = 89.99m, Descripcion = "Suscripción mensual premium" },
            new { Usuario = "Carlos López", Monto = 5000.00m, Descripcion = "Pago de servicios profesionales" },
            new { Usuario = "Ana Martínez", Monto = 25.50m, Descripcion = "Compra de libros digitales" },
            new { Usuario = "Pedro Rodríguez", Monto = 15000.00m, Descripcion = "Pago excesivo para probar límites" }
        };

        Console.WriteLine("🔄 Procesando transacciones con diferentes métodos de pago y notificaciones...");
        Console.WriteLine();

        // Ejemplo 1: Pago con tarjeta + notificación por correo
        Console.WriteLine("--- TRANSACCIÓN 1: Tarjeta + Correo ---");
        var pagoTarjeta = new ROMAPagoConTarjeta();
        var notificadorCorreo = new ROMANotificadorCorreo();
        var procesador1 = new ROMAProcesadorDePagos(pagoTarjeta, notificadorCorreo);
        procesador1.ROMAProcesarTransaccion(transacciones[0].Monto, transacciones[0].Usuario, transacciones[0].Descripcion);

        Console.WriteLine("--- TRANSACCIÓN 2: Transferencia + SMS ---");
        var pagoTransferencia = new ROMAPagoPorTransferencia();
        var notificadorSMS = new ROMANotificadorSMS();
        var procesador2 = new ROMAProcesadorDePagos(pagoTransferencia, notificadorSMS);
        procesador2.ROMAProcesarTransaccion(transacciones[1].Monto, transacciones[1].Usuario, transacciones[1].Descripcion);

        Console.WriteLine("--- TRANSACCIÓN 3: Transferencia + Correo ---");
        var procesador3 = new ROMAProcesadorDePagos(pagoTransferencia, notificadorCorreo);
        procesador3.ROMAProcesarTransaccion(transacciones[2].Monto, transacciones[2].Usuario, transacciones[2].Descripcion);

        Console.WriteLine("--- TRANSACCIÓN 4: Tarjeta + SMS ---");
        var procesador4 = new ROMAProcesadorDePagos(pagoTarjeta, notificadorSMS);
        procesador4.ROMAProcesarTransaccion(transacciones[3].Monto, transacciones[3].Usuario, transacciones[3].Descripcion);

        Console.WriteLine("--- TRANSACCIÓN 5: Transferencia con monto excesivo (fallará) ---");
        var procesador5 = new ROMAProcesadorDePagos(pagoTransferencia, notificadorCorreo);
        procesador5.ROMAProcesarTransaccion(transacciones[4].Monto, transacciones[4].Usuario, transacciones[4].Descripcion);

        Console.WriteLine("==============================================");
        Console.WriteLine("✨ Demostración de PRINCIPIOS SOLID aplicados:");
        Console.WriteLine("• Single Responsibility: Cada clase tiene una responsabilidad específica");
        Console.WriteLine("• Open/Closed: Se pueden agregar nuevos métodos de pago sin modificar código existente");
        Console.WriteLine("• Liskov Substitution: Las implementaciones son intercambiables");
        Console.WriteLine("• Interface Segregation: Interfaces específicas para cada funcionalidad");
        Console.WriteLine("• Dependency Inversion: El procesador depende de abstracciones, no de implementaciones");
        Console.WriteLine();
        Console.WriteLine("💡 Inyección de dependencias implementada en el constructor del ROMAProcesadorDePagos");
        Console.WriteLine("🔧 Nuevos métodos de pago y notificaciones se pueden agregar fácilmente");
        
        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
