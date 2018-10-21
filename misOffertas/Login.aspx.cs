using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL = myOffers.DAL;
using BLL= myOffers.BLL;

namespace misOffertas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLL.UsuarioBO usuarioBO = new myOffers.BLL.UsuarioBO();
            BLL.Repositorio repo = new BLL.Repositorio();


            var a = repo.tipoUsuario(txtUsuario.Text,txtPassword.Text);

            lblMensaje.Text = a.rol_usuario.ToString();

        }
    }
}