using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AttributeRoutingDemo.Models;

namespace AttributeRoutingDemo.Controllers
{
    
    public class ContactController : Controller
    {
        [Route("Contacts/{state?}")]
        public ActionResult Index(string state)
        {
            var contacts = new List<Contact>
            {
                new Contact { Id = 1, Name = "Jalpesh Vadgama", State = "Gujarat" },
                new Contact { Id = 2, Name = "Chitan Shah", State = "Maharastra" },
                new Contact { Id = 3, Name = "Anurag Gothi", State = "Rajashthan" }
            };
            if(!string.IsNullOrEmpty(state))
            {
                contacts = contacts.FindAll(c => c.State == state);
            }
            return View(contacts);
        }
        [Route("Contacts/Id/{id:int}")]
        public ActionResult GetContactsById(int id)
        {
            var contacts = new List<Contact>
            {
                new Contact { Id = 1, Name = "Jalpesh Vadgama", State = "Gujarat" },d
                new Contact { Id = 2, Name = "Chitan Shah", State = "Maharastra" },
                new Contact { Id = 3, Name = "Anurag Gothi", State = "Rajashthan" }
            };
           
                contacts = contacts.FindAll(c => c.Id == id);
           
            return View(contacts);
        }
	}
}