using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class DetalleRegistro {
        int idDetalleRegistro;
        int idRegistro;
        int idMercaderia;
        int cantidad;
        double areaCubica;

        public DetalleRegistro(int idDetalleRegistro, int idRegistro, int idMercaderia, int cantidad, double areaCubica) {
            this.idDetalleRegistro = idDetalleRegistro;
            this.idRegistro = idRegistro;
            this.idMercaderia = idMercaderia;
            this.cantidad = cantidad;
            this.areaCubica = areaCubica;
        }

        public DetalleRegistro(int idRegistro, int idMercaderia, int cantidad, double areaCubica) {
            this.idRegistro = idRegistro;
            this.idMercaderia = idMercaderia;
            this.cantidad = cantidad;
            this.areaCubica = areaCubica;
        }

        public int IdDetalleRegistro {
            get { return this.idDetalleRegistro; }
            set { this.idDetalleRegistro = value; }
        }

        public int IdRegistro {
            get { return this.idRegistro; }
            set { this.idRegistro = value; }
        }

        public int IdMercaderia {
            get { return this.idMercaderia; }
            set { this.idMercaderia = value; }
        }

        public int Cantidad {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public double AreaCubica {
            get { return this.areaCubica; }
            set { this.areaCubica = value; }
        }
    }
}
