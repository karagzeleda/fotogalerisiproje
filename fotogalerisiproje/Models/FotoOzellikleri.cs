namespace fotogalerisiproje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FotoOzellikleri")]
    public partial class FotoOzellikleri
    {
        [Key]
        public int FOTOID { get; set; }

        [StringLength(50)]
        public string FOTOAD { get; set; }

        [StringLength(50)]
        public string FOTORENK { get; set; }

        [StringLength(50)]
        public string FOTOSAHİBİ { get; set; }

        public int? KATEGORI { get; set; }

        public virtual Kategori Kategori1 { get; set; }
    }
}
