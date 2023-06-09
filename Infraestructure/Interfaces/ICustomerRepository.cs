﻿using Domain.Models;
using Infraestructure.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Interfaces
{
    public interface ICustomerRepository
    {
        public Task<List<GetCustomerPredictedDateDto>> GetCustomerPredictedDate();
    }
}
