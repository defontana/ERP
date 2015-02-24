using ERP.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAO.Support
{
    public class ClientDAO: IClientDAO
    {
        public string login(string texto)
        {
            return string.Format("Capa de DAO :{0}", texto);
        }
    }
}
