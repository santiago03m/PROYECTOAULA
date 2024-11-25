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

        // GET: api/Acceso/usuario/{id}
        [HttpGet]
        [Route("api/Acceso/usuario/{id}")]
        public Control_Acceso Get(int id)
        {
            using (LaQuiebraLTDAEntities3 objEntidad = new LaQuiebraLTDAEntities3())
            {
                return objEntidad.Control_Acceso.FirstOrDefault(c => c.ID_Usuario == id);
            }
        }

        // POST: api/Acceso
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Acceso/actualizar_usuario/{id}
        [HttpPut]
        [Route("api/Acceso/actualizar_usuario/{id}")]
        public IHttpActionResult Put(int id, [FromBody] Control_Acceso usuario)
        {
            if (usuario == null || usuario.ID_Usuario != id)
            {
                return BadRequest();
            }

            using (LaQuiebraLTDAEntities3 objEntidad = new LaQuiebraLTDAEntities3())
            {
                var usuarioExistente = objEntidad.Control_Acceso.FirstOrDefault(c => c.ID_Usuario == id);
                if (usuarioExistente == null)
                {
                    return NotFound();
                }

                usuarioExistente.Nombre_Usuario = usuario.Nombre_Usuario;
                usuarioExistente.Contrasena = usuario.Contrasena;
                usuarioExistente.Rol = usuario.Rol;
                usuarioExistente.Ultimo_Acceso = usuario.Ultimo_Acceso;
                usuarioExistente.Estado_Cuenta = usuario.Estado_Cuenta;

                objEntidad.SaveChanges();
                return Ok();
            }
        }

        // DELETE: api/Acceso/5
        public void Delete(int id)
        {
        }
    }
}
