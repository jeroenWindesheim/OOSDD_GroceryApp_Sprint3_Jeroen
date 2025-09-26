using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        
        public Client? Get(string email)
        {
            return _clientRepository.Get(email);
        }

        public Client? Get(int id)
        {
            return _clientRepository.Get(id);
        }

        public List<Client> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll();
            return clients;
        }

        public int CountClients()
        {
            Trace.WriteLine("ClientService: Test");
            return _clientRepository.CountClients();
        }

        public Client? Add(Client client)
        {
            // _clientRepository.Add(client);
            return client;
            // return (_clientRepository as dynamic).Add(client);
        }
    }
}
