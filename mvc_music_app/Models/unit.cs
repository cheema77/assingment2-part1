namespace mvc_music_app.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("unit")]
    public partial class unit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Unit_no { get; set; }

        [Required]
        [StringLength(50)]
        public string Song { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Genres { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Language { get; set; }

        [Required]
        [StringLength(50)]
        public string Album { get; set; }
    }
}
