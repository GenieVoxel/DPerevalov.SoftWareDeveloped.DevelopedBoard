using System;
using System.Collections.Generic;
using System.Text;

namespace DPerevalov.SoftWareDeveloped.MajorProject
{
    public class Manager
    {
        public static decimal WagesManager(string sDate, string tDate, string salaryRate)
        {
            decimal wagesManager = 0.0M;
            int percent = 5, rData;

            // Вызов метода CalculateAge из класса Settings для подсчета стажа
            rData = Settings.CalculateAge(DateTime.Parse(sDate), DateTime.Parse(tDate));

            for (int i = 1; i < rData; i++)
            {
                percent += 5;
                if (percent >= 40) percent = 40;
            }

            if (rData == 0) percent = 0;

            decimal dSalaryRate;
            dSalaryRate = Convert.ToDecimal(salaryRate);

            wagesManager = dSalaryRate + (dSalaryRate / 100 * percent);

            return wagesManager;
        }
    }
}
