using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;

using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        
        public IResult Add(Urun urun)
        { 
           

            _productDal.Add(urun);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Urun>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Urun>>(Messages.MaintenanceTime);
            }
            //iş kodları
            return new SuccessDataResult<List<Urun>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Urun>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Urun>>(_productDal.GetAll(p => p.UrunId == id));
        }

        public IDataResult<Urun> GetById(int productId)
        {
            return new SuccessDataResult<Urun>(_productDal.Get(p=>p.UrunId == productId));
        }

        public IDataResult<List<Urun>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Urun>>( _productDal.GetAll(p => p.UrunFiyat >= min && p.UrunFiyat <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>> (_productDal.GetProductDetails());
        }
    }
}
