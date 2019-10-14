using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Transportista {

        string dni;
        string nombre;
        List<Vehiculo> vehiculos;

        public Transportista(string dni, string nombre) {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Transportista(string dni, string nombre, List<Vehiculo> vehiculos) :
            this(dni, nombre) {
            this.vehiculos = vehiculos;
        }

        public string DNI {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public List<Vehiculo> Vehiculos {
            get { return this.vehiculos; }
            set { this.vehiculos = value; }
        }
    }
}
