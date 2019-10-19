using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Mercaderia {

        int idMercaderia;
        string descripcion;
        double areaCubica;
        int idCliente;
        int cantidad;

        public Mercaderia(int idMercaderia, string descripcion, double areaCubica, int idCliente, int cantidad) {
            this.idMercaderia = idMercaderia;
            this.descripcion = descripcion;
            this.areaCubica = areaCubica;
            this.idCliente = idCliente;
            this.cantidad = cantidad;
        }

        public Mercaderia(int idCliente, string descripcion, double areaCubica, int cantidad) {
            this.descripcion = descripcion;
            this.areaCubica = areaCubica;
            this.idCliente = idCliente;
            this.cantidad = cantidad;
        }

        public int IdMercaderia {
            get { return this.idMercaderia; }
            set { this.idMercaderia = value; }
        }

        public string Descripcion {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public double AreaCubica {
            get { return this.areaCubica; }
            set { this.areaCubica = value; }
        }

        public int IdCliente {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }

        public int Cantidad {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
    }
}
