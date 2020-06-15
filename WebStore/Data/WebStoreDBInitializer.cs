using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;

namespace WebStore.Data
{
    public class WebStoreDBInitializer
    {
        private readonly WebStoreDB _db;

        public WebStoreDBInitializer(WebStoreDB db) => _db = db;

        public void Initialize()
        {
            var db = _db.Database;
            //if(db.EnsureDeleted())
            //    if(!db.EnsureCreated())
            db.Migrate();

            if (_db.Products.Any()) return;

            using (db.BeginTransaction())
            {
                _db.Sections.AddRange(TestData.Sections);
                db.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[ProductSection] ON"); //только если ИД
                _db.SaveChanges();
                db.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[ProductSection] OFF"); //созданы вручную 
                
                db.CommitTransaction();
            }
            using (var transaction = db.BeginTransaction())
            {
                _db.Brands.AddRange(TestData.Brands);

                db.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[ProductBrand] ON"); //только если ИД
                _db.SaveChanges();
                db.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[ProductBrand] OFF"); //созданы вручную 
                transaction.Commit();
            }

            using (var transaction = db.BeginTransaction())
            {
                _db.Products.AddRange(TestData.Products);

                db.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Products] ON"); //только если ИД
                _db.SaveChanges();
                db.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Products] OFF"); //созданы вручную 
                transaction.Commit();
            }


        }
    }
}
