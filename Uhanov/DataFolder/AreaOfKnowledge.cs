//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uhanov.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class AreaOfKnowledge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AreaOfKnowledge()
        {
            this.BookAreaOfKnowledge = new HashSet<BookAreaOfKnowledge>();
        }
    
        public int IdAreaOfKnowledge { get; set; }
        public int NumberAreaOfKnowledge { get; set; }
        public string NameAreaOfKnowledge { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAreaOfKnowledge> BookAreaOfKnowledge { get; set; }
    }
}
