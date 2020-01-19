namespace NorthWindEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Type
    {
        public int id { get; set; }

        public int? ProductID { get; set; }

        public int? Hight { get; set; }

        public int? Width { get; set; }

        public int? Length { get; set; }

        public int? Area { get; set; }

        [Column("Type")]
        public int? Type1 { get; set; }

        public int? kg { get; set; }

        public virtual Product Product { get; set; }
    }
}
