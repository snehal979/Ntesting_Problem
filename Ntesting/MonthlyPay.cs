using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntesting
{
    public class MonthlyPay
    {
        public static void PaymentOfMonth(int P, int R, int Y)
        {
            //Y years to pay off a P principal loan amount at R percent interest compounded monthly.
            // where r= R/(12*100) and n = 12*Y
            float r = (float)R / (12 * 100);
            int n = 12 * Y;

            double payment = (P * r) /(1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly payment you have to make for year "+Y +" payment is " +payment);

        }

    }
}
