using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Empleado {
        int idEmpleado;
        int idCargo;
        string dni;
        string nombre;
        string usuario;
        string contraseña;
        int estado;

        public Empleado(int idCargo, string dni, string nombre, string usuario, string contraseña, int estado) {
            this.idCargo = idCargo;
            this.dni = dni;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.estado = estado;
        }

        public Empleado(int idEmpleado, int idCargo, string dni, string nombre, string usuario, string contraseña, int estado) {
            this.idEmpleado = idEmpleado;
            this.idCargo = idCargo;
            this.dni = dni;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.estado = estado;
        }

        public int IdEmpleado {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value; }
        }

        public int Estado {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public int IdCargo {
            get { return this.idCargo; }
            set { this.idCargo = value; }
        }

        public string DNI {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Contraseña {
            get { return this.contraseña; }
            set { this.contraseña = value; }
        }

        public string Usuario {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
    }
}
