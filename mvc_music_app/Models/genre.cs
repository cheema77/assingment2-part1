namespace mvc_music_app.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Genres { get; set; }

        [Required]
        [StringLength(50)]
        public string Language { get; set; }

        [Required]
        [StringLength(50)]
        public string Album { get; set; }
    }
}
