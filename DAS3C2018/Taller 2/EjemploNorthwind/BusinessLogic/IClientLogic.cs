using EjemploNorthwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IClientLogic
    {
        List<Client> GetClients();
        List<Client> GetClients(string nameFilter);
        Client GetById(int id);
    }
}
