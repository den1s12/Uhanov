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
    
    public partial class Instance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instance()
        {
            this.UsageBooks = new HashSet<UsageBooks>();
        }
    
        public int IdInstance { get; set; }
        public int IdBookAuthor { get; set; }
        public int UniqueChipher { get; set; }
    
        public virtual BookAuthor BookAuthor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsageBooks> UsageBooks { get; set; }
    }
}
