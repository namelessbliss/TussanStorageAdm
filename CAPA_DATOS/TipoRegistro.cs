using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class TipoRegistro {
        int idTipoRegistro;
        string descripcionTipo;

        List<Registro> registros;

        public TipoRegistro(int idTipoRegistro, string descripcionTipo) {
            this.idTipoRegistro = idTipoRegistro;
            this.descripcionTipo = descripcionTipo;
        }

        public int IdTipoRegistro {
            get { return this.idTipoRegistro; }
            set { this.idTipoRegistro = value; }
        }

        public string DescripcionTipo {
            get { return this.descripcionTipo; }
            set { this.descripcionTipo = value; }
        }

        public List<Registro> Registros {
            get { return this.registros; }
            set { this.registros = value; }
        }
    }
}
