using FirstWebApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controller
{
    public class ContactController
    {
        private List<Contact> contacts = [
            new (){ Name = "anil", Id = 1 },
            new (){ Name = "sunil", Id = 2 },
            new (){ Name = "joydip", Id = 3 },
            new (){ Name = "vinod", Id = 4 }
            ];

        public List<Contact> GetContacts() => contacts;

        public Contact GetContact([FromRoute(Name = "contactid")] int id) => contacts.Where(c => c.Id == id).First();

        [Consumes("application/json")]
        public Contact? AddContact([FromBody] Contact contact)
        {
            if (!contacts.Any(c => c.Id == contact.Id))
            {
                contacts.Add(contact);
                return contact;
            }
            else return null;
        }
    }
}
