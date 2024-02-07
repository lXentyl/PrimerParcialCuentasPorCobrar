namespace CuentasPorCobrar

{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Transacciones = new HashSet<Transacciones>();
        }
    
        public int IDempleados { get; set; }
        public string Nombre { get; set; }
        public decimal Cedula { get; set; }
        public int IDdepartamento { get; set; }
        public int IDPuesto { get; set; }
        public decimal SalarioMensual { get; set; }
        public int IDnomina { get; set; }
        public string Estado { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        public virtual Puesto Puesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacciones> Transacciones { get; set; }
    }
}
