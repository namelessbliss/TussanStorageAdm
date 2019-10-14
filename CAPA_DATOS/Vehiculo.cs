using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Vehiculo {

        string placa;
        string dniTransportisa;

        public Vehiculo(string placa, string dniTransportisa) {
            this.placa = placa;
            this.dniTransportisa = dniTransportisa;
        }

        public string Placa {
            get { return this.placa; }
            set { this.placa = value; }
        }

        public string DNITransportisa {
            get { return this.dniTransportisa; }
            set { this.dniTransportisa = value; }
        }
    }
}
