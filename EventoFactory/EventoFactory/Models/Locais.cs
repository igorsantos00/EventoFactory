//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventoFactory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locais
    {
        public Locais()
        {
            this.Eventos = new HashSet<Eventos>();
        }
    
        public int ID_Local { get; set; }
        public string Endereco { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Eventos> Eventos { get; set; }
    }
}