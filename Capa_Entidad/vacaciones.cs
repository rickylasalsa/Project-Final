//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class vacaciones
    {
        public int id_V { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public Nullable<System.DateTime> desde { get; set; }
        public Nullable<System.DateTime> haste { get; set; }
        public string comentario { get; set; }
    
        public virtual empleado empleado { get; set; }
    }
}