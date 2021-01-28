using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_rest_repository.Models;

namespace webapi_rest_repository.DataInterfaces
{
    public interface IProductInterfaces
    {
        Task<ActionResult<List<Product>>> GetAll();
    }
}
