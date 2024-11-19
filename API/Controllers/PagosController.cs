using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CONECTOR;

namespace API.Controllers
{
    public class PagosController : ApiController
    {
        // GET: api/Pagos
        public IEnumerable<Pagos> Get()
        {
            using(LaQuiebraLTDAEntities2 objEntidad = new LaQuiebraLTDAEntities2())
            {
                return objEntidad.Pagos.ToList();
            }
        }

        // GET: api/Pagos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pagos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pagos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pagos/5
        public void Delete(int id)
        {
        }
    }
}
