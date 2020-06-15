﻿using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;

namespace WebStore.DAL.Context
{
    class WebStoreDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        publi DbSet<Section> Sections { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public WebStoreDB(DbContextOptions<WebStoreDB> Options) : base(Options) { }
        {

        }
        
    }
}
