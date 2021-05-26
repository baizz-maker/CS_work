using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//api/webapi
    public class WebAPIController : ControllerBase
    {
        private readonly MySQLEntities context;

        public WebAPIController()
        {
            context = new MySQLEntities();
        }

        //GET:api/webapi?id=num
        [HttpGet]
        public ActionResult<List<Order>> get(int? id)
        {
            if (id == null)
            {
                return context.Set<Order>().ToList();
            }
            IQueryable<Order> query = from o in context.OrderSet where o.OrderID == id orderby o.OrderID select o;
            List<Order> result = new List<Order>();
            foreach (Order o in query)
            {
                result.Add(o);
            }
            return result;
        }

        //GET:api/webapi/num
        [HttpGet("{id}")]
        public ActionResult<List<Order>> get(int id)
        {
            IQueryable<Order> query = from o in context.OrderSet where o.OrderID == id orderby o.OrderID select o;
            List<Order> result = new List<Order>();
            foreach (Order o in query)
            {
                result.Add(o);
            }
            return result;
        }

        //POST:api/webpai
        [HttpPost]
        public ActionResult<Order> post(Order order)
        {
            try
            {
                context.OrderSet.Add(order);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }
    }

}
