using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOffers.BLL
{
    public class UsuarioBO
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string rut { get; set; }
        public tipoEstado tipoEstado { get; set; }
        public int rol_usuario { get; set; }
        public DateTime fecha { get; set; }

        public UsuarioBO()
        {
            this.init();

        }

        private void init()
        {
            this.id_usuario = 0;
            this.nombre_usuario = string.Empty;
            this.apellido_materno = string.Empty;
            this.apellido_paterno = string.Empty;
            this.correo = string.Empty;
            this.contrasena = string.Empty;
            this.rut = string.Empty;
            this.tipoEstado = tipoEstado.solicitado;
            this.rol_usuario = 0;
        }
    }
}
