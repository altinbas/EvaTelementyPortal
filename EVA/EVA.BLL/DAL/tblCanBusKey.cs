namespace EVA.BLL.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCanBusKey")]
    public partial class tblCanBusKey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCanBusKey()
        {
            tblValues = new HashSet<tblValue>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ModuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModuleText { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblValue> tblValues { get; set; }
    }
}
