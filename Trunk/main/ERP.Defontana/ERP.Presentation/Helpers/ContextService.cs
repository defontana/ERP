using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERP.Services.Interface;


namespace ERP.Presentation.Helpers
{
    public class ContextService : IContextService
    {
        private IBaseServices _baseServices = null;
        public ContextService()
        {
            _baseServices = (IBaseServices)ContextFactory.ApplicationContext["ServicesERP"];
        }

        #region IContextService Members

        public string loginUser(string userName)
        {
            return _baseServices.loginUser(userName + "/Interface Presentacion");
        }


        #endregion

    }
}