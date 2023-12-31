namespace Northwind.UI.DatabaseApp.Entities
{
    using Northwind.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Shipper : IEntity
    {

        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        public bool? Aktifmi { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
