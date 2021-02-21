using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Entities.DTOs
{

    public class CarDetailDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CarName { get; set; }
        
        public decimal DailyPrice { get; set; }
    }
}