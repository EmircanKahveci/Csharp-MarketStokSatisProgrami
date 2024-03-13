using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IProductService
    {
        IDataResult<List<Urun>> GetAll();
        IDataResult<List<Urun>> GetAllByCategoryId(int id);
        IDataResult<List<Urun>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Urun>GetById(int productId);
        IResult Add(Urun urun);

    }
}
