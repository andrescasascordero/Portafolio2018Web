//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myOffersDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAMPANA
    {
        public CAMPANA()
        {
            this.OFERTA = new HashSet<OFERTA>();
        }
    
        public decimal ID_CAMPANA { get; set; }
        public string NOMBRE_CAMPANA { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public System.DateTime FECHA { get; set; }
        public string ESTADO { get; set; }
        public decimal USUARIO_FK { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<OFERTA> OFERTA { get; set; }
    }
}
