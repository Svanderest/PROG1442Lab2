using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public class SalesCommission
    {
        public double Sales;
        public double Quota;       

        public double PercentOfQuota
        {
            get
            {
                if (Sales < 0)
                    throw new ArgumentOutOfRangeException("Sales");
                else if (Quota <= 0)
                    throw new ArgumentOutOfRangeException("Quota");
                return Math.Round(Sales / Quota * 100, 2);
            }
        }

        public double CommissionRate
        {
            get
            {
                if (PercentOfQuota < 95)
                    return 0;
                else if (PercentOfQuota < 100)
                    return 3;
                else if (PercentOfQuota < 120)
                    return 0.25 * PercentOfQuota - 19;
                else if (PercentOfQuota < 150)
                    return 0.35*PercentOfQuota - 31;
                else
                    return 0.45 * PercentOfQuota - 46;
            }
        }

        public double Commission
        {
            get
            {
                return Sales * CommissionRate;
            }
        }

        public SalesCommission(double sales, double quota)
        {
            Sales = sales;
            Quota = quota;
        }
    }
}
