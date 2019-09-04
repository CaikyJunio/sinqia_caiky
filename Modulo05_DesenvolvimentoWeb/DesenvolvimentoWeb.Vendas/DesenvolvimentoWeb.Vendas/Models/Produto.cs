//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesenvolvimentoWeb.Vendas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.Intens = new HashSet<Item>();
        }
    
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public byte[] Foto { get; set; }
        public string MimeType { get; set; }
        public double Preco { get; set; }
    
        public virtual Categoria CategoriaInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Intens { get; set; }
    }
}
