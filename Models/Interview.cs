//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Interview
    {
        public int Codigo_entrevista { get; set; }
        public int Codigo_user { get; set; }
        public string Entrevistador { get; set; }

        [Display(Name = "Data da entrevista"), Required]
        public System.DateTime Data_Entrevista { get; set; }
        public System.DateTime Data_criacao { get; set; }
        public string Vaga { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
