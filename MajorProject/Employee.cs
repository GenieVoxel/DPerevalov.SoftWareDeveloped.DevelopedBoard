using System;
using System.Collections.Generic;
using System.Text;

namespace DPerevalov.SoftWareDeveloped.MajorProject
{
    public class Employee
    {
        // sDate - Дата принятия на работу
        // tData - Дата на момент расчета зарплаты
        public static decimal WagesEmployee(string sDate, string tDate, string salaryRate)
        {
            decimal wagesEmployee = 0.0M;
            int percent = 3, rData;

            rData = Settings.CalculateAge(DateTime.Parse(sDate), DateTime.Parse(tDate));

            if (rData > 0)
            {
                for (int i = 1; i < rData; i++)
                {
                    percent += 3;
                    if (percent >= 30) percent = 30;
                }
            }

            decimal dSsalaryRate;
            dSsalaryRate = Convert.ToDecimal(salaryRate);

            wagesEmployee = dSsalaryRate + dSsalaryRate / 100 * percent;

            //Console.WriteLine(rData);

            return wagesEmployee;
        }
    }
}
