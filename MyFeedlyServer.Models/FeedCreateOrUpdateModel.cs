﻿using System.ComponentModel.DataAnnotations;
using MyFeedlyServer.Entities.Entities;

namespace MyFeedlyServer.Models
{
    public class FeedCreateOrUpdateModel : EntityModel<Feed>
    {
        public FeedCreateOrUpdateModel() : base()
        {
            Entity = new Feed();
        }

        public FeedCreateOrUpdateModel(Feed feed) : base(feed)
        {
        }


        [Required(ErrorMessage = nameof(Uri) + " is required")]
        public string Uri
        {
            get => Entity.Uri;
            set => Entity.Uri = value;
        }

        [Required(ErrorMessage = nameof(CollectionId) + " is required")]
        public int CollectionId { get; set; }
    }
}