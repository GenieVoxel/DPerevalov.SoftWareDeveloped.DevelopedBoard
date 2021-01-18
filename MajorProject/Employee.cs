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

            // Вызов метода CalculateAge из класса Settings для подсчета стажа
            rData = Settings.CalculateAge(DateTime.Parse(sDate), DateTime.Parse(tDate));

            
            for (int i = 1; i < rData; i++)
            {
                percent += 3;
                if (percent >= 30) percent = 30;
            }

            if (rData == 0) percent = 0;

            decimal dSalaryRate;
            dSalaryRate = Convert.ToDecimal(salaryRate);

            wagesEmployee = dSalaryRate + (dSalaryRate / 100 * percent);

            return wagesEmployee;
        }
    }
}
