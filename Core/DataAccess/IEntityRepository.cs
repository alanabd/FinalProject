using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;


namespace Core.DataAccess
{
    //generic constraint-yani generic olarak gelen tipe kısıtlama ekleme
    //class: referans tip olabilir(bizim tanımladıklarımızın yanında sistemin tanıdıkları da kabul
    //IEntity : IEntity olabilir veya IEntity implemente eden bir class olabilir 
    //new(): new() lenebilir olmalı yani doğrudan IEntity nin kullanımının önüne geçtik.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        List<T> GetAllCategory(int entityId);
    }
}
