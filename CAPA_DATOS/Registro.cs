using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Registro {
        int idRegistro;
        int idCliente;
        int idMercaderia;
        int idTipoRegistro;
        int idEmpleado;
        string fecha;
        int cantidad;
        double areaCubica;
        int estado;

        public Registro(int idRegistro, int idCliente, int idMercaderia, int idTipoRegistro, int idEmpleado, string fecha, int cantidad, double areaCubica, int estado) {
            this.idRegistro = idRegistro;
            this.idCliente = idCliente;
            this.idMercaderia = idMercaderia;
            this.idTipoRegistro = idTipoRegistro;
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.areaCubica = areaCubica;
            this.estado = estado;
        }

        public Registro(int idCliente, int idMercaderia, int idTipoRegistro, int idEmpleado, string fecha, int cantidad, double areaCubica, int estado) {
            this.idCliente = idCliente;
            this.idMercaderia = idMercaderia;
            this.idTipoRegistro = idTipoRegistro;
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.areaCubica = areaCubica;
            this.estado = estado;
        }

        public int IdRegistro {
            get { return this.idRegistro; }
            set { this.idRegistro = value; }
        }

        public int IdTipoRegistro {
            get { return this.idTipoRegistro; }
            set { this.idTipoRegistro = value; }
        }

        public int IdEmpleado {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value; }
        }

        public string Fecha {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public int Estado {
            get { return this.cantidad; }
            set { this.estado = value; }
        }

        public int Cantidad {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public double AreaCubica {
            get { return this.areaCubica; }
            set { this.areaCubica = value; }
        }

        public int IdCliente {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }

        public int IdMercaderia {
            get { return this.idMercaderia; }
            set { this.idMercaderia = value; }
        }
    }
}
