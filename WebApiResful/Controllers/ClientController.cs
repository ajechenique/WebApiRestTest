using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiResful.Models;

namespace WebApiResful.Controllers
{
    public class ClientController : ApiController
    {
        
        public IEnumerable<Client> GetAllClient()
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client { id = 1, name = "Antonio", lastname = "Echenique" });
            clients.Add(new Client { id = 2, name = "Erika", lastname = "Echenique" });
            clients.Add(new Client { id = 3, name = "Edecio", lastname = "Echenique" });
            return clients;
        }

        public IHttpActionResult GetClient(int id)
        {
            List<Client> clients = new List<Client>(GetAllClient());
            var client = clients.FirstOrDefault((c) => c.id == id);
            if(client != null)
            {
                return Ok(client);
            }
            else
            {
                return NotFound();
            }
        }
        


    }
}
