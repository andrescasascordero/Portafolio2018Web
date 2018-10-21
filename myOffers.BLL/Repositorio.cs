using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data.Entity;

namespace myOffers.BLL
{
    public class Repositorio
    {

        public UsuarioBO Create(UsuarioBO usuarioBO)
        {

            try
            {
                DAL.USUARIO usuarioDAL = new DAL.USUARIO();
                usuarioDAL.NOMBRES_USUARIO = usuarioBO.nombre_usuario;
                usuarioDAL.RUT = usuarioBO.rut;
                usuarioDAL.APELLIDO_PATERNO = usuarioBO.apellido_paterno;
                usuarioDAL.APELLIDO_MATERNO = usuarioBO.apellido_materno;
                usuarioDAL.CORREO = usuarioBO.correo;
                usuarioDAL.CONTRASENA = usuarioBO.contrasena;
                usuarioDAL.ESTADO = usuarioBO.tipoEstado.ToString();
                CommomBC.entities.USUARIO.Add(usuarioDAL);
                CommomBC.entities.SaveChanges();


                return usuarioBO;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public UsuarioBO Read(int id)
        {

            try
            {
                DAL.USUARIO usuarioDAL = CommomBC.entities.USUARIO.FirstOrDefault(a => a.ID_USUARIO == id);
                UsuarioBO usuarioBO = new UsuarioBO();
                usuarioBO.id_usuario = (int)usuarioDAL.ID_USUARIO;
                usuarioBO.nombre_usuario = usuarioDAL.NOMBRES_USUARIO;
                usuarioBO.apellido_paterno = usuarioDAL.APELLIDO_PATERNO;
                usuarioBO.apellido_materno = usuarioDAL.APELLIDO_MATERNO;
                usuarioBO.correo = usuarioDAL.CORREO;
                usuarioBO.contrasena = usuarioDAL.CONTRASENA;

                return usuarioBO;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }


        }

        public UsuarioBO update(UsuarioBO usuarioBO)
        {

            try
            {
                DAL.USUARIO usuarioDAL = CommomBC.entities.USUARIO.FirstOrDefault(a => a.ID_USUARIO == usuarioBO.id_usuario);
                usuarioDAL.NOMBRES_USUARIO = usuarioBO.nombre_usuario;
                usuarioDAL.RUT = usuarioBO.rut;
                usuarioDAL.APELLIDO_PATERNO = usuarioBO.apellido_paterno;
                usuarioDAL.APELLIDO_MATERNO = usuarioBO.apellido_materno;
                usuarioDAL.CORREO = usuarioBO.correo;
                usuarioDAL.CONTRASENA = usuarioBO.contrasena;
                usuarioDAL.ESTADO = usuarioBO.tipoEstado.ToString();
                CommomBC.entities.SaveChanges();

                return usuarioBO;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }


        }

        public List<DAL.USUARIO> ReadAllDAL()
        {

            return CommomBC.entities.USUARIO.ToList();
        }

        public UsuarioBO tipoUsuario(string correo, string password)
        {
            try
            {
           
                DAL.USUARIO usuarioDAL = CommomBC.entities.USUARIO.FirstOrDefault(a => a.CORREO == correo && a.CONTRASENA == password);
                UsuarioBO usuarioBO = new UsuarioBO();
                usuarioBO.id_usuario = (int)usuarioDAL.ID_USUARIO;
                usuarioBO.nombre_usuario = usuarioDAL.NOMBRES_USUARIO;
                usuarioBO.apellido_paterno = usuarioDAL.APELLIDO_PATERNO;
                usuarioBO.apellido_materno = usuarioDAL.APELLIDO_MATERNO;
                usuarioBO.correo = usuarioDAL.CORREO;
                usuarioBO.contrasena = usuarioDAL.CONTRASENA;
                usuarioBO.rol_usuario = (int)usuarioDAL.ROL_USUARIO_FK;


                return usuarioBO;

            }
            catch (Exception )
            {

                return null;
            }

        }



    }
}
