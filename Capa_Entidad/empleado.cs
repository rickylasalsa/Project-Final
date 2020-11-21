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
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.licencia = new HashSet<licencia>();
            this.nomina = new HashSet<nomina>();
            this.permiso = new HashSet<permiso>();
            this.salida = new HashSet<salida>();
            this.vacaciones = new HashSet<vacaciones>();
        }
    
        public int id { get; set; }
        public int CodigoEmp { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> Telefono { get; set; }
        public Nullable<int> Departamento { get; set; }
        public Nullable<int> Cargo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual cargo cargo1 { get; set; }
        public virtual departamento departamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<licencia> licencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nomina> nomina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permiso> permiso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salida> salida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacaciones> vacaciones { get; set; }
    }
}