using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen_software_Romero_Mariño.Modelos.Interfaces;

namespace examen_software_Romero_Mariño.Servicios;

public class ROMAProcesadorDePagos
{
    private readonly IROMAPago _metodoPago;
    private readonly IROMANotificador _notificador;

    // Constructor con inyección de dependencias
    public ROMAProcesadorDePagos(IROMAPago metodoPago, IROMANotificador notificador)
    {
        _metodoPago = metodoPago ?? throw new ArgumentNullException(nameof(metodoPago));
        _notificador = notificador ?? throw new ArgumentNullException(nameof(notificador));
    }

    public void ROMAProcesarTransaccion(decimal monto, string usuario, string descripcion)
    {
        Console.WriteLine("=== INICIANDO PROCESAMIENTO DE TRANSACCIÓN ===");
        Console.WriteLine($"Descripción: {descripcion}");
        Console.WriteLine();

        // Procesar el pago usando el método inyectado
        bool pagoExitoso = _metodoPago.ROMAProcesarPago(monto, usuario);

        // Determinar el mensaje de notificación
        string mensaje;
        if (pagoExitoso)
        {
            mensaje = $"Su pago de ${monto:F2} ha sido procesado exitosamente. Descripción: {descripcion}";
        }
        else
        {
            mensaje = $"Su pago de ${monto:F2} no pudo ser procesado. Descripción: {descripcion}. Por favor, intente nuevamente.";
        }

        // Enviar notificación usando el notificador inyectado
        _notificador.ROMAEnviarNotificacion(usuario, mensaje);

        Console.WriteLine("=== TRANSACCIÓN COMPLETADA ===");
        Console.WriteLine();
    }
}
