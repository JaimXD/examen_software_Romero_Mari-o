using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen_software_Romero_Mariño.Modelos.Interfaces;

namespace examen_software_Romero_Mariño.Modelos.Implementaciones.Notificadores;

public class ROMANotificadorCorreo : IROMANotificador
{
    public void ROMAEnviarNotificacion(string usuario, string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {usuario}:");
        Console.WriteLine($"   Mensaje: {mensaje}");
        Console.WriteLine($"   Estado: Correo enviado exitosamente");
        Console.WriteLine();
    }
}