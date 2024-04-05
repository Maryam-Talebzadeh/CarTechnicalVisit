using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services
{
    public class Utilities
    {
        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }
    }
}
