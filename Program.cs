using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Business.Concrete
using DataAccess.Concrete
using Entities.Concrete

namespace ConseleUI
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           CarManager carManager = new CarManager(InMemoryCarDal());
           foreach (var car in carManager.GetAll())
           {
            Console.WriteLine(car.Id+" "+car.Decsription);
           }
        }
    }
}