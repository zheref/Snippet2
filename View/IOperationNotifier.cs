using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snippet2.View
{
    public interface IOperationNotifier
    {
        void Notify(string msg);

        StringBuilder NotifyStream { get; set; }
    }
}
