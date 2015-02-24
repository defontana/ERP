using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.DAO.Interface;



namespace ERP.Services.Support
{
    public class ClientServices : IClientServices
    {
        IClientDAO service;
        public ClientServices(IClientDAO dao)
        {
            this.service = dao;
        }

        public string loginCliente(string entrada)
        {

            return string.Format("Capa de Servicio :{0}", service.login(entrada));
        }
    }
}
