//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace marafon_skills
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistrationEvent
    {
        public int RegistrationEventId { get; set; }
        public int RegistrationId { get; set; }
        public string EventId { get; set; }
        public Nullable<short> BibNumber { get; set; }
        public Nullable<int> RaceTime { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Event Event1 { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Registration Registration1 { get; set; }
    }
}
