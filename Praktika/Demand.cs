//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Demand()
        {
            this.Supply = new HashSet<Supply>();
        }
    
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int AgentId { get; set; }
        public int Id_type { get; set; }
        public string Address_City { get; set; }
        public string Address_Street { get; set; }
        public string Address_House { get; set; }
        public string Address_Number { get; set; }
        public Nullable<long> MinPrice { get; set; }
        public Nullable<long> MaxPrice { get; set; }
        public Nullable<int> Id_HouseDemand { get; set; }
        public Nullable<int> Id_LandDemand { get; set; }
        public Nullable<int> Id_ApartmentDemand { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual ApartmentDemand ApartmentDemand { get; set; }
        public virtual Client Client { get; set; }
        public virtual HouseDemand HouseDemand { get; set; }
        public virtual LandDemand LandDemand { get; set; }
        public virtual TypeRealEstate TypeRealEstate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply> Supply { get; set; }
    }
}
