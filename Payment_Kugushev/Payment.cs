//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Payment_Kugushev
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int ID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public Nullable<int> Num { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Users Users { get; set; }
    }
}
