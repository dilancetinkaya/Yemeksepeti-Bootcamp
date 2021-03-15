using Microsoft.AspNetCore.Mvc;
using Odev1.Data;
using Odev1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Odev1.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        

        private readonly DataProduct _dataProduct= DataProduct.Instance;
        

       

        [HttpGet]
        public List<ProductModel> Get()
        {
            return _dataProduct.Products;

        }

        [HttpGet("{id}")]
        public ProductModel Get(int id)
        {
            var data = _dataProduct.Products.FirstOrDefault(c => c.Id == id);
            return data;
        }

        [HttpPost]
        public void Post([FromBody] ProductModel product)
        {
            _dataProduct.Products.Add(product);

        }
        [HttpPut("{id}")]
        public ProductModel Put([FromBody] ProductModel product)
        {
            var editproduct = _dataProduct.Products.FirstOrDefault(x=> x.Id==product.Id);
            editproduct.Name = product.Name;
            editproduct.Price = product.Price;
           return product;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deleteProduct = _dataProduct.Products.FirstOrDefault(x => x.Id == id);
            _dataProduct.Products.Remove(deleteProduct);
        }

        [HttpOptions]
        public HttpResponseMessage Options()
        {
            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
    }
}