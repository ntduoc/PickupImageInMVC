namespace PickupImage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public long id { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        public string Content { get; set; }

        public string ImagePath { get; set; }
    }
}
