//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kval
{
    using System;
    using System.Collections.Generic;
    
    public partial class YuridicheskoyeLitsoSet
    {
        public int Id_face { get; set; }
        public string SokrashchennoyeNaimenovaniye { get; set; }
        public string Addres { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public Nullable<int> Id_men { get; set; }
    
        public virtual MenedzherSet MenedzherSet { get; set; }
    }
}
