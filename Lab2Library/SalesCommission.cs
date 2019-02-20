using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public static class SalesCommission
    {
        public static double PercentOfQuota(double sales, double quota)
        {
            if (sales < 0)
                throw new ArgumentOutOfRangeException("sales");
            if (quota <= 0)
                throw new ArgumentOutOfRangeException("quota");
            return Math.Round(sales / quota, 2);
        }

        public static double CommissionRate(double percent)
        {
            if (percent < 0.95)
                return 0;
            else if (percent < 1)
                return 0.03;
            else if (percent < 1.20)
                return 0.25 * percent - 0.19;
            else if (percent < 1.50)
                return 0.35 * percent - 0.31;
            else
                return 0.45 * percent - 0.46;
        }
    }
}
