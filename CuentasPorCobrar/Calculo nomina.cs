namespace CuentasPorCobrar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tiposdeingresos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tiposdeingresos()
        {
            this.Transacciones = new HashSet<Transacciones>();
        }
    
        public int IDtiposdeingresos { get; set; }
        public string Nombre { get; set; }
        public string Dependeelsalario { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacciones> Transacciones { get; set; }
    }
}
