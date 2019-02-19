﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public class SalesCommission
    {
        private double Sales;
        private double Quota;
        private double Salary;

        public double PercentOfQuota
        {
            get
            {                
                return Math.Round(Sales / Quota, 2);
            }
        }

        public double CommissionRate
        {
            get
            {
                if (PercentOfQuota < 0.95)
                    return 0;
                else if (PercentOfQuota < 1)
                    return 0.03;
                else if (PercentOfQuota < 1.20)
                    return 0.25 * PercentOfQuota - 0.19;
                else if (PercentOfQuota < 1.50)
                    return 0.35*PercentOfQuota - 0.31;
                else
                    return 0.45 * PercentOfQuota - 0.46;
            }
        }

        public double Commission
        {
            get
            {
                return Salary * CommissionRate;
            }
        }

        public SalesCommission(double sales, double quota, double salary = 0)
        {
            if (sales < 0)
                throw new ArgumentOutOfRangeException("Sales");
            else if (quota <= 0)
                throw new ArgumentOutOfRangeException("Quota");
            Sales = sales;
            Quota = quota;
            Salary = salary;
        }
    }
}
