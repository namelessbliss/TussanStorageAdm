using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SysAlmacen.ope {
    public partial class Op : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            empleado.Text = Global.empleado.Nombre;
        }

        protected void btnLogout_Click(object sender, EventArgs e) {
            Global.empleado = null;
            Response.Redirect("~/default.aspx");
        }
    }
}