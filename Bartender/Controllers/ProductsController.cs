using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bartender.Models;

namespace Bartender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Products>> GetProducts()
        {
            List<Products> productList = new List<Products>();

            productList.Add(new Products { ProductId = 1, ProductName = "Milkshake" });
            productList.Add(new Products { ProductId = 2, ProductName = "Orange Juice" });
            productList.Add(new Products { ProductId = 3, ProductName = "Invalid Product" });

            return productList;
        }

        //// GET: api/Products/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetProducts([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var products = await _context.Products.FindAsync(id);

        //    if (products == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(products);
        //}

        // PUT: api/Products/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProducts([FromRoute] int id, [FromBody] Products products)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != products.ProductId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(products).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Products
        //[HttpPost]
        //public async Task<IActionResult> PostProducts([FromBody] Products products)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Products.Add(products);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetProducts", new { id = products.ProductId }, products);
        //}

        // DELETE: api/Products/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProducts([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var products = await _context.Products.FindAsync(id);
        //    if (products == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Products.Remove(products);
        //    await _context.SaveChangesAsync();

        //    return Ok(products);
        //}
    }
}