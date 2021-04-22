namespace karenvelazquez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("articulo")]
    public partial class articulo
    {
        [Key]
        public int idArticulo { get; set; }

        public int idEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public DateTime inicio { get; set; }

        public DateTime final { get; set; }

        public virtual estado estado { get; set; }
    }
}
