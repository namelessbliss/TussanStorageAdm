using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class TipoMercaderia {
        public int idTipoMercaderia;
        public string descripcionMercaderia;
        public double precioMercaderia;

        public TipoMercaderia(int idTipoMercaderia, string descripcionMercaderia, double precioMercaderia) {
            this.idTipoMercaderia = idTipoMercaderia;
            this.descripcionMercaderia = descripcionMercaderia;
            this.precioMercaderia = precioMercaderia;
        }

        public TipoMercaderia(string descripcionMercaderia, double precioMercaderia) {
            this.descripcionMercaderia = descripcionMercaderia;
            this.precioMercaderia = precioMercaderia;
        }

    }
}
