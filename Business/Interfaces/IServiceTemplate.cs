using CoffeShopManagement.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace CoffeShopManagement.Services.Interfaces
{
    internal interface IServiceTemplate<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> List(Expression<Func<TEntity, bool>> filter = null); //Tablodaki verilerin listesini döndür
        TEntity Get(Expression<Func<TEntity, bool>> filter); //Tablodaki özel bir veriyi döndür
        TEntity Add(TEntity entity); //Tabloya veri ekler
        TEntity Update(TEntity entity); //Tablodaki özel bir veriyi güncelle
        TEntity Delete(TEntity entity); //Tablodaki özel bir veriyi sil
        void Delete(Expression<Func<TEntity, bool>> filter); //LINQ sorgusu sonucu  gelen verileri tablodan sil
        TEntity AddOrUpdate(TEntity entity); //Tabloda aynı veri yok ise ekle var is o veriyi güncelle
        bool Exist(Expression<Func<TEntity, bool>> filter); //Tabloda özel veri var ise true yoksa false döndür
        DbContext CreateInstance(bool newContext = false); //Yeni bir veritabanı bağlantı örneği oluştur
        void ConnectToInstance(DbContext context); //Varolan bir veritabanı bağlantı örneğine bağlan
        void Dispose(); //Bağlantıyı kapat

    }
}
