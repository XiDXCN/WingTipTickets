//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tenant.Mvc.Core.Contexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Concert
    {
        public int ConcertId { get; set; }
        public string ConcertName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ConcertDate { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> VenueId { get; set; }
        public Nullable<int> PerformerId { get; set; }
        public Nullable<int> SaveToDbServerType { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
