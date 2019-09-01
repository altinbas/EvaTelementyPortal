namespace EVA.BLL.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblValue")]
    public partial class tblValue
    {
        public int Id { get; set; }

        public int CanBusKeyId { get; set; }

        [Required]
        [StringLength(10)]
        public string Value { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ReceivedDate { get; set; }

        public virtual tblCanBusKey tblCanBusKey { get; set; }
    }
}
