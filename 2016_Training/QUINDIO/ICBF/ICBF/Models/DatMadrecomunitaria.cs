//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICBF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatMadrecomunitaria
    {
        public DatMadrecomunitaria()
        {
            this.Regjardines = new HashSet<Regjardines>();
        }
    
        public string cedula { get; set; }
        public string nom_ape { get; set; }
        public string telefono { get; set; }
        public string dire { get; set; }
        public System.DateTime fec_nac { get; set; }
    
        public virtual ICollection<Regjardines> Regjardines { get; set; }
    }
}
