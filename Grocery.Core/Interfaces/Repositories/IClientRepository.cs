﻿using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IClientRepository
    {
        public Client? Get(string email);
        public Client? Get(int id);
        public List<Client> GetAll();
        public int CountClients();
        public Client? AddClientRepo(string name, string email, string password);
        // public Client? Add(Client client);
    }
}
