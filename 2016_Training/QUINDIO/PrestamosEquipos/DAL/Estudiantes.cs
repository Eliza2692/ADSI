//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiantes
    {
        public Estudiantes()
        {
            this.Prestamos = new HashSet<Prestamos>();
        }
    
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Carrera { get; set; }
        public string Sancion { get; set; }
        public Nullable<System.DateTime> FechaSancion { get; set; }
    
        public virtual ICollection<Prestamos> Prestamos { get; set; }
    }
}
