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
    
    public partial class Feedbacks
    {
        public int ID_Feedback { get; set; }
        public Nullable<decimal> Nota { get; set; }
        public string Comentario { get; set; }
        public int ID_Evento { get; set; }
        public int ID_Usuario { get; set; }
    
        public virtual Eventos Eventos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}