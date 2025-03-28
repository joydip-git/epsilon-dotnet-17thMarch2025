using ContactServiceApp.Models;
using ContactServiceApp.Repository;

namespace ContactServiceApp.DAL
{
    public class ContactDao : IDaoContract<Contact, long>
    {
        private readonly EpsilonDbContext _context;

        public ContactDao(EpsilonDbContext context)
        {
            _context = context;
        }

        public bool Add(Contact item)
        {
            try
            {
                var records = _context.Contacts;
                if (!records.Any(c => c.MobileNumber == item.MobileNumber))
                {
                    records.Add(item);
                    var result = _context.SaveChanges();
                    return result > 0;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Contact? Get(long primaryKeyValue)
        {
            try
            {
                var records = _context.Contacts;
                if (records.Any(c => c.MobileNumber == primaryKeyValue))
                {
                    return records
                        .Where(c => c.MobileNumber == primaryKeyValue)
                        .First();
                }
                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<Contact> GetAll()
        {
            try
            {
                //return [.. _context.Contacts];
                return _context.Contacts.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Remove(long primaryKeyValue)
        {
            try
            {
                var records = _context.Contacts;
                if (records.Any(c => c.MobileNumber == primaryKeyValue))
                {
                    var found = records
                        .Where(c => c.MobileNumber == primaryKeyValue)
                        .First();

                    records.Remove(found);

                    var result = _context.SaveChanges();

                    return result > 0;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(long primaryKeyValue, Contact updatedItem)
        {
            try
            {
                var records = _context.Contacts;
                if (records.Any(c => c.MobileNumber == primaryKeyValue))
                {
                    var found = records
                        .Where(c => c.MobileNumber == primaryKeyValue)
                        .First();

                    found.Name = updatedItem.Name;
                    found.Location = updatedItem.Location;
                    found.EmailId = updatedItem.EmailId;

                    records.Update(found);
                    return _context.SaveChanges() > 0;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
