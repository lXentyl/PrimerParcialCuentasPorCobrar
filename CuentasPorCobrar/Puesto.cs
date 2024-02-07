namespace CurntasPorCobrar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puesto()
        {
            this.Empleados = new HashSet<Empleados>();
        }
    
        public int IDpuesto { get; set; }
        public string Nombre { get; set; }
        public string NiveldeRiesgo { get; set; }
        public decimal Salariominimo { get; set; }
        public decimal Salariomaximo { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
