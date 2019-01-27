using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface ISesion
    { //verifica el inicio de sesión de los usuarios
        bool VerificarInicio(string nombre, string clave);
    }
}
