using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vestel_Demo_Api.DAL.Context;
using Vestel_Demo_Api.DAL.Entities;

namespace Vestel_Demo_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            using var context = new WebApiContext();
            var values= context.Categories.ToList();
            return Ok(values);
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            using var context = new WebApiContext();
            var category = context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(category);
            }
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            using var context = new WebApiContext();
            var updatedCategory = context.Find<Category>(category.ID);
            if (updatedCategory == null)
            {
                return NotFound();
            }
            else
            {
                updatedCategory.Name = category.Name;
                context.Update(updatedCategory);
                context.SaveChanges();
                return NoContent();
            }
        }
        [HttpDelete("id")]
        public IActionResult CategoryDelete(int id)
        {
            using var context = new WebApiContext();
            var deletedcategory = context.Categories.Find(id);
            if (deletedcategory == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(deletedcategory);
                context.SaveChanges();
                return NoContent();
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var context = new WebApiContext();
            context.Add(category);
            context.SaveChanges();
            return NoContent();
        }
    }
}
