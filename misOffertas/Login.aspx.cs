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


            var Coderole = repo.tipoUsuario(txtUsuario.Text,txtPassword.Text);
            var mensaje = "";
            switch (Coderole.rol_usuario)
            {

                case 10:
                    mensaje = "Administrador Mis Ofertas";
                    break;
                case 11:
                    mensaje = "Administrador Retail";
                    break;
                case 12:
                    mensaje = "Cliente Retail";
                    break;
                default:
                    mensaje = "Mis Ofertas";
                    break;
            }
            lblMensaje.Text = mensaje;

        }
    }
}