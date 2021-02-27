using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Core.DataAccess;
using Entities.DTOs;


namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> getProductDetailDto();
    }
}
