﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaan.Models;
using Zaan.Models.Model;

namespace Zaan.Repositories.Customers
{
    public interface ICustomerRepository : IBase<Customer>
    {
        Task test();
    }
}
