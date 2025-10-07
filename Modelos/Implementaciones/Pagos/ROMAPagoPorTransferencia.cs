using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen_software_Romero_Mariño.Modelos.Interfaces;

namespace examen_software_Romero_Mariño.Modelos.Implementaciones.Pagos;

public class ROMAPagoPorTransferencia : IROMAPago
{
    public bool ROMAProcesarPago(decimal monto, string usuario)
    {
        Console.WriteLine("Procesando pago por transferencia bancaria...");
        Console.WriteLine($"   Usuario: {usuario}");
        Console.WriteLine($"   Monto: ${monto:F2}");
        
        // Simulación de procesamiento
        Console.WriteLine("   Verificando cuenta bancaria...");
        Console.WriteLine("   Iniciando transferencia...");
        
        bool exito = monto > 0 && monto <= 10000; // Simulación: éxito si el monto está entre 0 y 10000
        
        if (exito)
        {
            Console.WriteLine("--Transferencia completada exitosamente");
        }
        else
        {
            Console.WriteLine("--Error en la transferencia bancaria");
        }
        
        Console.WriteLine();
        return exito;
    }
}