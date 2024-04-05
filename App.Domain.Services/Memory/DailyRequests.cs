using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App.Domain.Services.Memory
{
    public class DailyRequests
    {
        static int Requests;

        static void ResetRequests(object state)
        {
            Requests = 0;
        }

        Timer timer = new Timer(ResetRequests, null, TimeSpan.Zero, TimeSpan.FromHours(24));
    }
}
