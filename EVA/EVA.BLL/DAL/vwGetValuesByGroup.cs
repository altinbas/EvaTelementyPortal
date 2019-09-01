namespace EVA.BLL.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// It is use for anlyising the cambus values. The view combaines 
    /// </summary>
    [Table("vwGetValuesByGroup")]
    public partial class vwGetValuesByGroup
    {
        public long? Number { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Value { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CanBusKeyId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ModuleText { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime ReceivedDate { get; set; }
    }
}
