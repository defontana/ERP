using ERP.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAO.Support
{
    public class ClientDAO : IClientDAO
    {
        public string loginUser(string userName)
        {

            if (userName != null || userName.Length != 0)
            {

                return userName + "/ DAO ";
            }
            else
            {
                throw new Exception("No ingresa nombre usuario");
            }
        }
    }
}
