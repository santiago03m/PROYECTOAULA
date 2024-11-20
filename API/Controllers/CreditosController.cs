using CONECTOR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CreditosController : ApiController
    {
        // GET: api/Creditos
        public IEnumerable<Creditos> Get()
        {
            using (LaQuiebraLTDAEntities1 db = new LaQuiebraLTDAEntities1())
            {
                return db.Creditos.ToList();
            }
        }

        // GET: api/Creditos/5
        public IHttpActionResult Get(int id)
        {
            using (LaQuiebraLTDAEntities1 db = new LaQuiebraLTDAEntities1())
            {
                var credito = db.Creditos.Find(id);
                if (credito == null)
                {
                    return NotFound();
                }
                return Ok(credito);
            }
        }

        // POST: api/Creditos
        public HttpResponseMessage Post([FromBody] Creditos objCreditos)
        {
            EntityState operacion = EntityState.Added;
            return opercion(objCreditos, operacion);
        }

        // PUT: api/Creditos/5
        public HttpResponseMessage Put([FromBody] Creditos objCreditos)
        {
            EntityState operacion = EntityState.Modified;
            return opercion(objCreditos, operacion);
        }

        // DELETE: api/Creditos/5
        public HttpResponseMessage Delete([FromBody] Creditos objCreditos)
        {
            EntityState operacion = EntityState.Deleted;
            return opercion(objCreditos, operacion);
        }

        private HttpResponseMessage opercion([FromBody] Creditos objMascotas, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {

                using (LaQuiebraLTDAEntities1 objEntidad = new LaQuiebraLTDAEntities1())
                {
                    objEntidad.Entry(objMascotas).State = operacion;
                    resp = objEntidad.SaveChanges();
                    objMenRespuesta = Request.CreateResponse(HttpStatusCode.OK, resp);
                }

            }
            catch (Exception er)
            {
                objMenRespuesta = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, er.Message);
            }
            return objMenRespuesta;
        }
    }
}

