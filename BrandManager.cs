using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Business.Concrete
{

    public static class BrandManager:IBrandService
    {
        IBrandDal _brandDal;
        public void Add(Brand brand)
        {
        	_brandDal.Add(brand);
        }
        public BrandManager(IBrandDal brandDal)
        {
        	_brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
        	return _brandDal.GetAll();
        }
        public Brand GetById(int brandId)
        {
        	return _brandDal.Get(b=>b.Id == brandId);
        }
    }
}