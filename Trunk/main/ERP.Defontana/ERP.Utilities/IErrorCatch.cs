using System;

namespace ERP.Utilities
{
    public interface  IErrorCatch
    {
        void Save(Exception ex);
    }
}
