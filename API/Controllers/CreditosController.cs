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

        // POST: api/Creditos/credito_nuevo
        [HttpPost]
        [Route("api/Creditos/credito_nuevo")]
        public IHttpActionResult Post([FromBody] Creditos credito)
        {
            if (credito == null)
            {
                return BadRequest("El crédito no puede ser nulo.");
            }

            using (LaQuiebraLTDAEntities1 db = new LaQuiebraLTDAEntities1())
            {
                db.Creditos.Add(credito);
                db.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = credito.ID_Credito }, credito);
            }
        }

        // PUT: api/Creditos/actualizar/{id}
        [HttpPut]
        [Route("api/Creditos/actualizar/{id}")]
        public IHttpActionResult Put(int id, [FromBody] Creditos credito)
        {
            if (credito == null || credito.ID_Credito != id)
            {
                return BadRequest("El ID del crédito no coincide.");
            }

            using (LaQuiebraLTDAEntities1 db = new LaQuiebraLTDAEntities1())
            {
                var creditoExistente = db.Creditos.Find(id);
                if (creditoExistente == null)
                {
                    return NotFound();
                }

                creditoExistente.ID_Cliente = credito.ID_Cliente;
                creditoExistente.Monto_Total = credito.Monto_Total;
                creditoExistente.Fecha_Inicio = credito.Fecha_Inicio;
                creditoExistente.Fecha_Vencimiento = credito.Fecha_Vencimiento;
                creditoExistente.Tasa_Interes = credito.Tasa_Interes;
                creditoExistente.Estado = credito.Estado;
                creditoExistente.Cuotas = credito.Cuotas;

                db.Entry(creditoExistente).State = EntityState.Modified;
                db.SaveChanges();
                return Ok(creditoExistente);
            }
        }

        // DELETE: api/Creditos/eliminar/{id}
        [HttpDelete]
        [Route("api/Creditos/eliminar/{id}")]
        public IHttpActionResult Delete(int id)
        {
            using (LaQuiebraLTDAEntities1 db = new LaQuiebraLTDAEntities1())
            {
                var credito = db.Creditos.Find(id);
                if (credito == null)
                {
                    return NotFound();
                }

                db.Creditos.Remove(credito);
                db.SaveChanges();
                return Ok();
            }
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

