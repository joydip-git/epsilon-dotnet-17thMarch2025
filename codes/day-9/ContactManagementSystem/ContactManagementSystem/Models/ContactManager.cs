namespace ContactManagementSystem.Models
{
    public class ContactManager : IContactManager
    {
        private HttpClient _httpClient;
        private string url = "https://localhost:7218/api/Contact";
        public ContactManager()
        {
            _httpClient = new HttpClient();
        }

        public async Task<bool> AddContactAsync(ContactModel contact)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync<ContactModel>($"{url}/add", contact);
                if (response != null)
                    return true;
                else
                    throw new Exception("could not add");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteContactAsync(string mobileNo)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync($"{url}/delete/{mobileNo}");
                if (response.IsSuccessStatusCode)
                    return true;
                else
                    throw new Exception($"could not delete contact for given mobile no:{mobileNo}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ContactModel>> FetchAllContactsAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<ContactModel[]>($"{url}/all");
                if (response != null && response.Length > 0)
                {
                    return response.ToList();
                }
                else
                    throw new Exception("no record found...");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ContactModel> GetContactAsync(string mobileNo)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<ContactModel>($"{url}/{mobileNo}");
                if (response != null)
                    return response;
                else throw new Exception($"no contact for given mobile no:{mobileNo} found");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateContactAsync(ContactModel contact)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync<ContactModel>($"{url}/update/{contact.MobileNumber}", contact);
                if (response != null)
                    return true;
                else
                    throw new Exception("could not update");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
