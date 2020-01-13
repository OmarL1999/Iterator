using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Clases;
namespace Iterator.Interfaz
{
    public interface IIteratorVehiculo
    {
        void Primero();
        Vehiculo Actual();
        Vehiculo Siguiente();
        bool QuedanElementos();
    }
}
