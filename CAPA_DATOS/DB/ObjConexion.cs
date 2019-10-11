using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class ObjConexion {
        string db;
        string user;
        string pass;
        string server;

        public ObjConexion(string db, string user, string pass, string server) {
            this.db = db;
            this.user = user;
            this.pass = pass;
            this.server = server;
        }

        public string DB {
            get { return this.db; }
            set { this.db = value; }
        }

        public string User {
            get { return this.user; }
            set { this.user = value; }
        }

        public string Pass {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public string Server {
            get { return this.server; }
            set { this.server = value; }
        }
    }
}
