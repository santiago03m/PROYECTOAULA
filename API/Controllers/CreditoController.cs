using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CONECTOR;

namespace API.Controllers
{
    public class CreditoController : ApiController
    {
        // GET: api/Credito
        public IEnumerable<Creditos> Get()
        {
            using(LaQuiebraLTDAEntities1 objEntidad = new LaQuiebraLTDAEntities1())
            {
                return objEntidad.Creditos.ToList();
            }
        }

        // GET: api/Credito/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Credito
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Credito/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Credito/5
        public void Delete(int id)
        {
        }
    }
}
