using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application.Features.Class
{
    public class ChucNang
    {
        public static bool IsAllDigits(string input)
        {
            return input.All(char.IsDigit);
        }
    }
}
