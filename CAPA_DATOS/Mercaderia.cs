using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Mercaderia {

        int idMercaderia;
        int idTipoMercaderia;
        int idCliente;
        string descripcion;
        double areaCubica;
        string categoria;
        string unidad;
        int cantidad;

        public Mercaderia(int idMercaderia, int idTipoMercaderia, int idCliente, string descripcion, double areaCubica, string categoria, string unidad, int cantidad) {
            this.idMercaderia = idMercaderia;
            this.idTipoMercaderia = idTipoMercaderia;
            this.idCliente = idCliente;
            this.descripcion = descripcion;
            this.areaCubica = areaCubica;
            this.categoria = categoria;
            this.unidad = unidad;
            this.cantidad = cantidad;
        }

        public Mercaderia(int idTipoMercaderia, int idCliente, string descripcion, double areaCubica, string categoria, string unidad, int cantidad) {
            this.idTipoMercaderia = idTipoMercaderia;
            this.idCliente = idCliente;
            this.descripcion = descripcion;
            this.areaCubica = areaCubica;
            this.categoria = categoria;
            this.unidad = unidad;
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

        public int IdTipoMercaderia {
            get { return this.idTipoMercaderia; }
            set { this.idTipoMercaderia = value; }
        }

        public string Categoria {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string Unidad {
            get { return this.unidad; }
            set { this.unidad = value; }
        }
    }
}
