using CONECTOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AccesoController : ApiController
    {
        // GET: api/Acceso
        public IEnumerable<Control_Acceso> Get()
        {
            using(LaQuiebraLTDAEntities3 objEntidad = new LaQuiebraLTDAEntities3())
            {
                return objEntidad.Control_Acceso.ToList();
            }
        }

        // GET: api/Acceso/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Acceso
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Acceso/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Acceso/5
        public void Delete(int id)
        {
        }
    }
}
