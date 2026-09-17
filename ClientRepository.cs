using CompanyManagement.Models;

namespace CompanyManagement.Services
{

    public class ClientRepository
    {
        private Dictionary<Guid, Client> _clients = new Dictionary<Guid, Client>();


        public void AddClient(Client client)
        {
            _clients.Add(client.Id, client);


        }

        public Client? GetClientById(Guid id)
        {
            if (_clients.TryGetValue(id, out Client client))
            {

                return client;

            }

            return null;

        }
        public List<Client> GetAllClients()
        {
            return _clients.Values.ToList();

        }


        public List<Client> GetActiveClients()
        {
            List<Client> activeClients = new List<Client>();

            foreach (Client client in _clients.Values)
            {
            if (client.IsClientActive())
                {
                    activeClients.Add(client);  

                }
                
            }
            return activeClients;
        }       
    }
}
