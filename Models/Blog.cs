namespace blogsite_asp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string blog_title { get; set; }

        [StringLength(50)]
        public string blog_category { get; set; }

        [StringLength(50)]
        public string publish_status { get; set; }

        [StringLength(50)]
        public string publish_date { get; set; }

        public DateTime? publish_time { get; set; }

        public string blog_tags { get; set; }

        public string blog_content { get; set; }

        public string blog_imageurl { get; set; }

        public string blog_owner { get; set; }
    }
}
