//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eco1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movimentos()
        {
            this.Artigos = new HashSet<Artigos>();
        }
    
        public int IdMovimento { get; set; }
        public int IdArtigo { get; set; }
        public int IdEntidade { get; set; }
        public int NumeroDoc { get; set; }
        public int Quantidade { get; set; }
        public string TipoDeMovimento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigos> Artigos { get; set; }
        public virtual Entidades Entidades { get; set; }
    }
}
