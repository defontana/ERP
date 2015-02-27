using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Services.Interface;
using ERP.DAO.Interface;

namespace ERP.Services.Support
{
    public class ClientServices : BaseServices
    {

         private IClientDAO _clienteDAO = null;

         public ClientServices()
            : base()
        {
            _clienteDAO = (IClientDAO)_applicationContext["ClientDAO"];
        }

        //Escribimos las implementaciones en esta seccion
         public override string loginUser(string userName)
        {
            return _clienteDAO.loginUser(userName + "/Capa Servicio");
        }
    }
}
