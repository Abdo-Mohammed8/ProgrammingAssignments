using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_oop_3.Q03
{
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
