using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phamthitrmy_1721050372.Models.MyProcess
{
    public class XuLy
    {
        public bool kiemtraSNT(int number)
        {
            int bien_dem = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    bien_dem++;
                }
            }
            if (bien_dem == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}