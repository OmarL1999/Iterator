using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interfaz;
using Iterator.Clases;
namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos el registro
            IRegistroVehiculos registro = new RegistroVehiculos();

            // Insertamos unos cuantos elementos
            registro.InsertarVehiculo("Volkswagen", "Polo", 12300);
            registro.InsertarVehiculo("Volkswagen", "Golf GTI", 18900);
            registro.InsertarVehiculo("Volkswagen", "Passat", 27000);
            registro.InsertarVehiculo("Volkswagen", "Scirocco", 32100);
            registro.InsertarVehiculo("Volkswagen", "Touareg", 21800);

            // Obtenemos el iterator
            IIteratorVehiculo iterador = registro.ObtenerIterator();

            // Mientras queden elementos
            while (iterador.QuedanElementos())
            {
                // Obtenemos el siguiente elemento
                Vehiculo v = iterador.Siguiente();

                // Mostramos su contenido
                Console.WriteLine(v.Marca + " " + v.Modelo + " fabricado el " + v.FechaFabricacion.ToShortDateString() + " (" + v.Precio + " euros)");
            }
        }
    }
}
