using ContactServiceApp.DAL;
using ContactServiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IDaoContract<Contact, long> _dao;
        public ContactController(IDaoContract<Contact, long> dao)
        {
            _dao = dao;
        }

        [Route("all")]
        [HttpGet]
        public ActionResult<ICollection<Contact>> GetContacts()
        {
            try
            {
                var records = _dao.GetAll();
                if (records.Count > 0)
                    return this.Ok(records);
                else
                    return this.NoContent();
            }
            catch (Exception ex)
            {
                return this.Problem(ex.ToString(), statusCode: 500);
            }
        }

        [Route("{mobile}")]
        [HttpGet]
        public ActionResult<Contact> GetContact([FromRoute(Name = "mobile")] long mobileNumber)
        {
            try
            {
                var record = _dao.Get(mobileNumber);
                if (record != null)
                    return this.Ok(record);
                else
                    return this.NoContent();
            }
            catch (Exception ex)
            {
                return this.Problem(ex.ToString(), statusCode: 500);
            }
        }


        [Route("add")]
        [HttpPost]
        public ActionResult<Contact> AddContact([FromBody] Contact contact)
        {
            try
            {
                var status = _dao.Add(contact);
                if (status)
                    return this.CreatedAtAction(nameof(AddContact), contact);
                else
                    return this.NoContent();
            }
            catch (Exception ex)
            {
                return this.Problem(ex.ToString(), statusCode: 500);
            }
        }


        [Route("update/{mobile}")]
        [HttpPut]
        public ActionResult<Contact> UpdateContact(
            [FromRoute(Name = "mobile")] long mobileNumber,
            [FromBody] Contact contact
            )
        {
            try
            {
                var status = _dao.Update(mobileNumber, contact);
                if (status)
                    return this.Ok(contact);
                else
                    return this.NoContent();
            }
            catch (Exception ex)
            {
                return this.Problem(ex.ToString(), statusCode: 500);
            }
        }

        [Route("delete/{mobile}")]
        [HttpDelete]
        public ActionResult RemoveContact(
           [FromRoute(Name = "mobile")] long mobileNumber)
        {
            try
            {
                var status = _dao.Remove(mobileNumber);
                if (status)
                    return this.Ok();
                else
                    return this.NoContent();
            }
            catch (Exception ex)
            {
                return this.Problem(ex.ToString(), statusCode: 500);
            }
        }
    }
}
