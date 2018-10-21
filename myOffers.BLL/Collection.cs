using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = myOffers.DAL;
namespace myOffers.BLL
{
    class Collection
    {
        private List<UsuarioBO> GenerarListado(List<DAL.USUARIO> usuariosDAL)
        {
            List<UsuarioBO> usuariosBO = new List<UsuarioBO>();
            foreach (var usuarioDAL in usuariosDAL)
            {
                UsuarioBO usuarioBO = new UsuarioBO();
                usuarioBO.id_usuario = (int)usuarioDAL.ID_USUARIO;
                usuarioBO.apellido_paterno = usuarioDAL.APELLIDO_PATERNO;
                usuarioBO.apellido_materno = usuarioDAL.APELLIDO_MATERNO;
                usuarioBO.correo = usuarioDAL.CORREO;
                usuarioBO.contrasena = usuarioDAL.CONTRASENA;
                usuarioBO.fecha = (DateTime)usuarioDAL.FECHA;
                usuarioBO.rut = usuarioBO.rut;
                usuarioBO.tipoEstado = (tipoEstado)Enum.Parse(typeof(tipoEstado), usuarioDAL.ESTADO, true);
                usuariosBO.Add(usuarioBO);
            }
            return usuariosBO;
        }

        public List<UsuarioBO> ReadAll()
        {
            Repositorio repo = new Repositorio();
            return GenerarListado(repo.ReadAllDAL());

        }

    }
}
