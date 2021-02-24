using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
