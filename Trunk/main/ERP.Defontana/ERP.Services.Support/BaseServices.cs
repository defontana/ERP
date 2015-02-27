using System;
using System.Collections.Generic;
using System.Text;
using ERP.Services.Interface;
using Spring.Core;
using Spring.Context;
using Spring.Context.Support;

namespace ERP.Services.Support
{

    public abstract class BaseServices : IBaseServices
    {
        protected IApplicationContext _applicationContext = null;

        public BaseServices()
        {
            _applicationContext = ContextRegistry.GetContext();
        }

        #region BaseServices Members

        public abstract string loginUser(string userName);


        #endregion
    }
}
