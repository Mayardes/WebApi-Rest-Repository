using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_rest_repository.Data;
using webapi_rest_repository.DataInterfaces;
using webapi_rest_repository.Models;
using webapi_rest_repository.Repository;

namespace webapi_rest_repository.Controllers
{
    [Route("product")]
    public class ProductController : ControllerBase
    {
        public readonly IProductInterfaces _productinterfaces;
        public ProductController(IProductInterfaces datainterfaces)
        {
            _productinterfaces = datainterfaces;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromBody] Product model)
        {
            return await _productinterfaces.GetAll();
        }
    }
}
