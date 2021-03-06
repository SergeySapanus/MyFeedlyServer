﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyFeedlyServer.Entities.Contracts;

namespace MyFeedlyServer.Entities.Entities
{
    [Table("Users")]
    public class User : IEntity
    {
        private ICollection<Collection> _collections = new HashSet<Collection>();
        private readonly ILazyLoader _lazyLoader;

        public User()
        {
        }

        private User(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public ICollection<Collection> Collections
        {
            get => _lazyLoader.Load(this, ref _collections);
            set => _collections = value;
        }
    }
}