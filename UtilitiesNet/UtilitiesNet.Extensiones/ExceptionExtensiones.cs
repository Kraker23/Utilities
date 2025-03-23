using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNet.Extensiones
{
    public static class ExceptionExtensiones
    {
        private static string getErrorException(this Exception exception)
        {
            string result = string.Empty;
            if (exception.InnerException != null && !string.IsNullOrEmpty(exception.InnerException.ToString()))
            {
                result = "Inner -> " + exception.InnerException.ToString();
            }
            if (!string.IsNullOrEmpty(exception.Message))
            {
                result = result + (!string.IsNullOrEmpty(result) ? ". Message -> " : "Message -> " + exception.Message);
            }
            if (string.IsNullOrEmpty(result))
            {
                result = "Error.";
            }
            return result;
        }

    }
}
