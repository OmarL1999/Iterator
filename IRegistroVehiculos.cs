using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Clases;
namespace Iterator.Interfaz
{
    public interface IRegistroVehiculos
    {
        void InsertarVehiculo(string marca, string modelo, double precio);
        Vehiculo MostrarInformacionVehiculo(int indice);
        IIteratorVehiculo ObtenerIterator();
    }
}
