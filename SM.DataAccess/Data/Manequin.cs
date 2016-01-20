namespace SM.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manequin")]
    public partial class Manequin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        private ICollection<Scenario> _scenarios;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scenario> Scenarios
        {
            get { return _scenarios ?? (_scenarios = new List<Scenario>()); }
            set { _scenarios = value; }
        }
    }
}
