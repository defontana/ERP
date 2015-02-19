using System;
using log4net;

namespace ERP.Utilities.Log
{
    public static class ErrorCatch
    { 
        
        public  static void Save(Exception ex) {
                Log.Error("Error:", ex);
        }

        //static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ErrorCatch));          
        static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }      
}
