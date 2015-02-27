using System;
using System.Collections.Generic;
using System.Text;

using Spring.Context;
using Spring.Context.Support;


namespace ERP.Presentation.Helpers
{
    public class ContextFactory
    {
         private static IApplicationContext applicationContext = null;

         static ContextFactory()
        {
            applicationContext = ContextRegistry.GetContext();
        }

        public static IApplicationContext ApplicationContext
        {
            get { return applicationContext; }
        }
    }
}