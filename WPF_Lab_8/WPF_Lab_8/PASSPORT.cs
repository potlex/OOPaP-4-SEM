//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Lab_8
{
    using System;
    using System.Collections.Generic;
    
    public partial class PASSPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PASSPORT()
        {
            this.PERSON = new HashSet<PERSON>();
        }
    
        public int id_passport { get; set; }
        public string serial { get; set; }
        public int number { get; set; }
        public byte[] photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSON> PERSON { get; set; }
    }
}
