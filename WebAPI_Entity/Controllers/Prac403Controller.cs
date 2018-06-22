using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Entity.Controllers
{
    public class Prac403Controller : ApiController
    {
        // GET: api/Prac403
        public List<UserInfo> Get()
        {
            using (ModelPracOne m = new ModelPracOne())
            {
                var listUsrInfo = m.UserInfoes.ToList();
                return listUsrInfo;
            }    
        }

        // GET: api/Prac403/5
        public UserInfo Get(string id)
        {
            using (ModelPracOne m = new ModelPracOne())
            {   
                var listUsrInfo = m.UserInfoes.SingleOrDefault(p => p.Id == id);
                return listUsrInfo;
            }
        }

        // POST: api/Prac403
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Prac403/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Prac403/5
        public void Delete(int id)
        {
        }
    }
}
