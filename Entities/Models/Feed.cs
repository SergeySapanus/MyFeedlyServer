﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Feeds")]
    public class Feed
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = nameof(Name) + " is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = nameof(Hash) + " is required")]
        public string Hash { get; set; }

        public virtual ICollection<CollectionFeed> CollectionsFeeds { get; set; } = new HashSet<CollectionFeed>();

        public virtual ICollection<News> News { get; set; } = new HashSet<News>();
    }
}