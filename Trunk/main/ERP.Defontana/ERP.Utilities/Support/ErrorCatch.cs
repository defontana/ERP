using System;
using log4net;

namespace ERP.Utilities.Support
{
    public  class ErrorCatch: IErrorCatch
    { 
        
        public void Save(Exception ex) {
                Log.Error("Error:", ex);
        }

        //static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ErrorCatch));          
        static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }

    public class ErrorCatch2 : IErrorCatch
    {

        public void Save(Exception ex)
        {
            Log.Error("Otra IMPL:", ex);
        }

        //static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ErrorCatch));          
        static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }     
}
