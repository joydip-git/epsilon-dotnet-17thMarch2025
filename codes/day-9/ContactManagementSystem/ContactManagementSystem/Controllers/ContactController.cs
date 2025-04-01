using ContactManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactManagementSystem.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> logger;
        private readonly IContactManager contactManager;

        public ContactController(ILogger<ContactController> logger, IContactManager contactManager)
        {
            this.logger = logger;
            this.contactManager = contactManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            try
            {
                var contacts = await contactManager.FetchAllContactsAsync();
                return this.View(contacts);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetContact([FromRoute(Name = "value")] string mobileNo)
        {
            try
            {
                var contact = await contactManager.GetContactAsync(mobileNo);
                return this.View(contact);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContact([FromRoute(Name = "value")] string mobileNo)
        {
            try
            {
                var contact = await contactManager.GetContactAsync(mobileNo);
                return this.View(contact);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(ContactModel contactModel)
        {
            try
            {
                var status = await contactManager.UpdateContactAsync(contactModel);
                if (status)
                    return this.RedirectToAction("GetContacts");
                else
                    return View("Error");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AddContact()
        {
            try
            {
                return this.View(null);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(ContactModel contactModel)
        {
            try
            {
                var response = await contactManager.AddContactAsync(contactModel);
                if (response)
                    return this.RedirectToAction("GetContacts");
                else
                    return View("Error");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteContact([FromRoute(Name = "value")] string mobileNo)
        {
            try
            {
                var response = await contactManager.DeleteContactAsync(mobileNo);
                if (response)
                    return this.RedirectToAction("GetContacts");
                else
                    return View("Error");
            }
            catch (Exception)
            {
                return this.View("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
