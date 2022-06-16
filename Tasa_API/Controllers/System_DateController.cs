using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tasa_API.Models;

namespace Tasa_API.Controllers
{
    public class System_DateController : ApiController
    {
        private DB_Context db = new DB_Context();

        // GET: api/System_Date
        public IQueryable<System_Date> GetSystem_Date()
        {
            return db.System_Date;
        }

        // GET: api/System_Date/5
        [ResponseType(typeof(System_Date))]
        public IHttpActionResult GetSystem_Date(string id)
        {
            System_Date system_Date = db.System_Date.Find(id);
            if (system_Date == null)
            {
                return NotFound();
            }

            return Ok(system_Date);
        }

        // PUT: api/System_Date/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSystem_Date(string id, System_Date system_Date)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != system_Date.Date)
            {
                return BadRequest();
            }

            db.Entry(system_Date).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!System_DateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/System_Date
        [ResponseType(typeof(System_Date))]
        public IHttpActionResult PostSystem_Date(System_Date system_Date)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.System_Date.Add(system_Date);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (System_DateExists(system_Date.Date))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = system_Date.Date }, system_Date);
        }

        // DELETE: api/System_Date/5
        [ResponseType(typeof(System_Date))]
        public IHttpActionResult DeleteSystem_Date(string id)
        {
            System_Date system_Date = db.System_Date.Find(id);
            if (system_Date == null)
            {
                return NotFound();
            }

            db.System_Date.Remove(system_Date);
            db.SaveChanges();

            return Ok(system_Date);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool System_DateExists(string id)
        {
            return db.System_Date.Count(e => e.Date == id) > 0;
        }
    }
}