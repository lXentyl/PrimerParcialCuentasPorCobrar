namespace CuentasPorCobrar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departamento()
        {
            this.Empleados = new HashSet<Empleados>();
        }
    
        public int IDdepartamento { get; set; }
        public string Cargo { get; set; }
        public string UbicacionFisica { get; set; }
        public string Encargado { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
