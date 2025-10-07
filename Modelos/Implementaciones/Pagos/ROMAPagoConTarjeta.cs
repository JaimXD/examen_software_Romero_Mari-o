using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen_software_Romero_Mariño.Modelos.Interfaces;

namespace examen_software_Romero_Mariño.Modelos.Implementaciones.Pagos;

public class ROMAPagoConTarjeta : IROMAPago
{
    public bool ROMAProcesarPago(decimal monto, string usuario)
    {
        Console.WriteLine("Procesando pago con tarjeta de crédito...");
        Console.WriteLine($"   Usuario: {usuario}");
        Console.WriteLine($"   Monto: ${monto:F2}");
        
        // Simulación de procesamiento
        Console.WriteLine("   Validando tarjeta...");
        Console.WriteLine("   Autorizando transacción...");
        
        bool exito = monto > 0; // Simulación simple: éxito si el monto es mayor a 0
        
        if (exito)
        {
            Console.WriteLine("--Pago procesado exitosamente con tarjeta");
        }
        else
        {
            Console.WriteLine("--Error en el procesamiento del pago con tarjeta");
        }
        
        Console.WriteLine();
        return exito;
    }
}