//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login1
{
    using System;
    using System.Collections.Generic;
    
    public partial class forma
    {
        public int Id { get; set; }
        public string mail { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Nullable<int> Id_Role { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
