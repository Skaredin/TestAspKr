//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestT
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestToUser
    {
        public int Id { get; set; }
        public Nullable<int> IdTest { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
