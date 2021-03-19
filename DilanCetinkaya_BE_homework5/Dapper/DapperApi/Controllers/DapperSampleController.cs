using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DapperApi.Model;

namespace DapperApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DapperSampleController : ControllerBase

    {
        private readonly ILogger<DapperSampleController> _logger;
        private readonly IConfiguration _configuration;

          public DapperSampleController(ILogger<DapperSampleController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

        }

         [HttpGet]
        public IActionResult DapperInsert()
        {

            //veritabanımıza bağlandık, Test tablomuza veri eklemek için sql komutu yazdık. for ile oluşturduğumuz dataları tablomuza ekledik
            //göndereceğimiz parametrelerin isimlerini tablo ile aynı olacak şekilde verdik
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();

                      string sql = "";
                    var affected = 0;
                    sql = @"INSERT INTO dbo.Test (Id, FirstName, Surname)
                                        Values(@Id, @FirstName, @Surname)";

                    object[] objList = new object[10];
                    for (var i = 0; i < 10; i++)
                    {
                        objList[i] = new
                        {
                            Id = 1 + i,
                            FirstName = "Name-" + i,
                            Surname = "Surname" + i,

                        };
                    }

                    affected = db.Execute(sql, objList);

               
            }

            return Ok();

        }
        public IActionResult DapperDelete()
        {
            //Test tablomuzda bulunan verilerden ıd parametresine göre silme işlemi gerçekleştirdik,sql komutumuzu yazdık.
            //Execute ile ıd si 1,2 olan verileri tablodan sildik.
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
               
                    string sql = @"Delete From dbo.Test Where Id=@Id";
                    var affected = db.Execute(sql, new[]
                     {
                    new { Id = 1 },
                    new { Id = 2 }
                });
                


            }
            return Ok();

        }
        public IActionResult DapperUpdate()
        {
            //Test tablomuzda bulunan verilerimizi güncelleyecek sql sorgusunu yazdık. Execute ettik 
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                

                    string sql = @"Update dbo.Test Set FirstName = @FirstName Where Id=@Id";
                    var paramsArray = new[]
                    {
                       new { Id =3 , FirstName = "Dilan"}

                   };

                    var affected = db.Execute(sql, paramsArray);
                
            }


            return Ok();
        }
        public IActionResult DapperSelectQuery()

        {
            //Query kullarak  [AdventureWorks2019].[HumanResources].[Department] da bulunan verilerimizi listeledik
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                
                if (db.State != ConnectionState.Open)
                    db.Open();
                
                    string sql = @"Select * From  [AdventureWorks2019].[HumanResources].[Department];";
                    var uniqMeasure = db.Query(sql);
    
            }

            return Ok();
        }
        public IActionResult DapperDeleteQuery()

        {
            //Query kullanarak  ıd si 4 olan verimizi sildik.
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                
                    string sql = @"Delete from dbo.Test where Id=@Id";
                    var data = db.Query(sql,
                        new { Id = 4 }
                    );


                
            }

            return Ok();
        }
        public IActionResult DapperTransactional()
        {
            //Birden çok database olduğu zaman birinde hata olursa commit etmeyi engelliyor.Birden çok sorgu yazabiliyoruz

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
               

                    using (var transaction = db.BeginTransaction())
                    {
                        string sql = @"Insert into dbo.Test(ıd, FirstName,Surname) values (@Id,@Name,@Surname)";

                        Test test = new Test
                        {
                            Id = 20,
                            FirstName = "Dilan",
                            Surname = "cetinkaya"
                        };
                        db.Execute(sql, test, transaction);
                        PersonPhone personPhone = new PersonPhone
                        {
                            BusinessEntityID = 21,
                            PhoneNumber = "521565",
                            PhoneNumberTypeID = 39,
                            ModifiedDate = DateTime.Now
                        };
                        db.Execute(sql, personPhone, transaction);

                        transaction.Commit();
                    
                }
            }


            return Ok();
        }
        public IActionResult DapperSP()
        { //Veritabanına TestSP adlı bir PROCEDURE oluşturduk. Exec TestSP dediğimiz anda Test adlı tablomuzda olan verilere ulaşıyoruz.
          //Herhangi bir parametremiz olmadığından null geçtik.

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                
                    string sql = "TestSP";
                    var test = db.Execute(sql, null, commandType: CommandType.StoredProcedure);
                }
            

            return Ok();
        }
         public IActionResult OneToManyMapping()
        {// aralarında ona to many ilişki olan iki tabloyu databasemizden inner joinle tek tablo gibi göstermek için kullandık  

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                
                    string sql = "select * from [Production].[ProductModel] as A Inner Join [Production].[Product] as B ON A.ProductModelID = B.ProductModelID;";

                    var categoryDictionary = new Dictionary<int, ProductModel>();

                    var data = db.Query<ProductModel, Product, ProductModel>(sql,
                        (productmodel, product) =>
                        {
                            ProductModel productData;
                            if (!categoryDictionary.TryGetValue(productmodel.ProductModelID, out productData))
                            {
                                productData = productmodel;
                                productData.Products = new List<Product>();
                                categoryDictionary.Add(productData.ProductModelID, productData);
                            }
                            productData.Products.Add(product);
                            return productData;
                        },
                        splitOn: "ProductID"
                    ).Distinct().ToList();


                    return Ok(data);

                
            }
        }
         public IActionResult OneToOneMapping()
        {//// aralarında ona to one ilişki olan iki tabloyu databasemizden inner joinle tek tablo gibi göstermek için kullandık 
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                string sql = "select * from [Purchasing].[PurchaseOrderHeader] as Pur Inner Join [HumanResources].[Employee] as Emp ON Pur.EmployeeID = Emp.BusinessEntityID;";

                var data = db.Query<OrderHeader, Employee, OrderHeader>(
                        sql,
                        (order, employee) =>
                        {
                            order.Employee = employee;
                            return order;
                        },
                        splitOn: "EmployeeID"
                        ).Distinct().ToList();
                return Ok(data);
            }
        }
          public IActionResult ResultMapping()
        {
            //QueryFirstOrDefault ile Test tablosunda bulunan datalardan herhangi birini getirdik
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                string sql = @"Select * From  dbo.Test;";
                var detail = db.QueryFirstOrDefault(sql);

                return Ok(detail);
            }
            }

        public IActionResult MultipleQueryMapping()
        {
            //Querymultiple ile  iki sorguda ortak olan parametreleri eşleyerek tek bir yapı olarak listeledik
            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
             string sql  = @"select* from[Production].[ProductModel] where ProductModelID = @ProductModelID; 
                select* from[Production].[Product] where ProductModelID = @ProductModelID;";



                ProductModel productModel;
                using (var multiple = db.QueryMultiple(sql, new { ProductModelID = 20 }))
                {
                    productModel = multiple.Read<ProductModel>().First();
                    productModel.Products = multiple.Read<Product>().ToList();
                }
                return Ok(productModel);
            }
        }
            }

}