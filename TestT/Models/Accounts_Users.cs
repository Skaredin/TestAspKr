//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounts_Users
    {
        public long id { get; set; }
        public string userId { get; set; }
        public long accountId { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
