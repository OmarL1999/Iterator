using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Clases;
using Iterator.Interfaz;
namespace Iterator.Clases
{
    public class IteratorVehiculo : IIteratorVehiculo
    {
        // Referencia al listado completo
        private ArrayList vehiculos;

        // Almacenaremos el índice en el que se encuentra el iterador
        private int posicionActual = -1;

        // El constructor inyectará el ArrayList en el objeto
        public override IteratorVehiculo(ArrayList listado)
        {
            this.vehiculos = listado;
        }
        // Operación 1: Reinicio del índice, colocándolo en el elemento anterior al primero
        public void Primero()
        {
            this.posicionActual = -1;
        }
        // Operación 2: Acceso al elemento actual
        public Vehiculo Actual()
        {
            // Si no existen elementos, devolveremos null.
            // Si el indice actual es mayor que el mayor indice aceptable, devolveremos null.
            // Si el indice actual es -1, devolveremos null.
            if ((this.vehiculos == null) ||
                (this.vehiculos.Count == 0) ||
                (posicionActual > this.vehiculos.Count - 1) ||
                (this.posicionActual < 0))
                return null;

            // Devolvemos el elemento correspondiente al elemento actual
            else
                return (Vehiculo)this.vehiculos[posicionActual];
        }
        // Operación 3: Acceso al siguiente elemento
        public Vehiculo Siguiente()
        {
            // Si no existen elementos, devolveremos null.
            // Si el indice siguiente es mayor que el mayor indice aceptable, devolveremos null.
            if ((this.vehiculos == null) ||
                (this.vehiculos.Count == 0) ||
                (posicionActual + 1 > this.vehiculos.Count - 1))
                return null;

            // Aumentamos el índice en una unidad y devolvemos ese elemento
            else
                return (Vehiculo)this.vehiculos[++posicionActual];
        }
        // Operación 4: Comprobación de si existen elementos en la colección
        public bool QuedanElementos()
        {
            // Devolvemos un booleano que será true si la posición siguiente es menor o igual que el
            // máximo índice aceptable (número de elementos del array - 1).
            return (posicionActual + 1 <= this.vehiculos.Count - 1);
        }
    }
}
