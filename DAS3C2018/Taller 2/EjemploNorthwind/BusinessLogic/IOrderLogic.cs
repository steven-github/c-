using EjemploNorthwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IOrderLogic
    {
        Order GetById(int id);
        void EditLine(int lineId, int quantity);
    }
}
