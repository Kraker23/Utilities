using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNet.Funciones
{
    public static class TaskUtil
    {
        public static Task CargarTask(Action action, Action<Exception> onError = null)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                try
                {
                    action.Invoke();
                }
                catch (Exception ex)
                {
                    if (onError != null) onError.Invoke(ex);
                }
            });
            return task;
        }
    }
}
