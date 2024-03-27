﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model:Entity<Guid>
{
       
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }

    public Guid BrandId { get; set; }
    public virtual Brand? Brand { get; set; }
      

    //public Model()
    //{
     
    //}

    //public Model(Guid id, Guid brandId, string name, decimal dailyPrice, string imageUrl) : this()
    //{
    //    Id = id;
    //    BrandId = brandId;       
    //    Name = name;
    //    DailyPrice = dailyPrice;
    //    ImageUrl = imageUrl;

    //}
}
