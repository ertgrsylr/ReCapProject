using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Entities.Abstract;

namespace Entities.Concrete
{

    public static class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Decsription { get; set; }
        
    }
}