//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssemblyInstructionsDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssemblyInstructionsDetail()
        {
            this.OperationParts = new HashSet<OperationParts>();
        }
    
        public short idAssemblyInstructionsDetail { get; set; }
        public short idAssemblyInstructions { get; set; }
        public string CodeOperation { get; set; }
        public string DescOperation { get; set; }
        public Nullable<short> NumberOfUsers { get; set; }
        public Nullable<short> OperationOrder { get; set; }
    
        public virtual AssemblyInstructions AssemblyInstructions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationParts> OperationParts { get; set; }
    }
}
