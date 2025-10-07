using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen_software_Romero_Mariño.Modelos.Interfaces;

namespace examen_software_Romero_Mariño.Modelos.Implementaciones.Notificadores;

public class ROMANotificadorSMS : IROMANotificador
{
    public void ROMAEnviarNotificacion(string usuario, string mensaje)
    {
        Console.WriteLine($"Enviando SMS a {usuario}:");
        Console.WriteLine($"   Mensaje: {mensaje}");
        Console.WriteLine($"   Estado: SMS enviado exitosamente");
        Console.WriteLine();
    }
}