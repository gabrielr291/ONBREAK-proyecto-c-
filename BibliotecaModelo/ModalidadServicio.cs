//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaModelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModalidadServicio
    {
        public ModalidadServicio()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public int PersonalBase { get; set; }
    
        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual TipoEvento TipoEvento { get; set; }
    }
}
