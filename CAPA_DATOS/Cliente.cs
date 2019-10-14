using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Cliente {

        int idCliente;
        string nombreEmpresa;
        string dueñoEmpresa;
        string ruc;
        int estado;

        List<Mercaderia> mercaderias;

        public Cliente(int idCliente, string nombreEmpresa, string dueñoEmpresa, string rUC, int estado) {
            this.idCliente = idCliente;
            this.nombreEmpresa = nombreEmpresa;
            this.dueñoEmpresa = dueñoEmpresa;
            ruc = rUC;
            this.estado = estado;
        }

        public Cliente(string nombreEmpresa, string dueñoEmpresa, string rUC, int estado) {
            this.nombreEmpresa = nombreEmpresa;
            this.dueñoEmpresa = dueñoEmpresa;
            ruc = rUC;
            this.estado = estado;
        }

        public Cliente(int idCliente, string nombreEmpresa, string dueñoEmpresa, string ruc, int estado, List<Mercaderia> mercaderias) :
            this(idCliente, nombreEmpresa, dueñoEmpresa, ruc, estado) {
            this.mercaderias = mercaderias;
        }

        public Cliente(string nombreEmpresa, string dueñoEmpresa, string ruc, int estado, List<Mercaderia> mercaderias) :
            this(nombreEmpresa, dueñoEmpresa, ruc, estado) {
            this.mercaderias = mercaderias;
        }

        public int IdCliente {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }

        public string NombreEmpresa {
            get { return this.nombreEmpresa; }
            set { this.nombreEmpresa = value; }
        }

        public string DueñoEmpresa {
            get { return this.dueñoEmpresa; }
            set { this.dueñoEmpresa = value; }
        }

        public string RUC {
            get { return this.ruc; }
            set { this.ruc = value; }
        }

        public int Estado {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public List<Mercaderia> Mercaderias {
            get { return this.mercaderias; }
            set { this.mercaderias = value; }
        }
    }
}
