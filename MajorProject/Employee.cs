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

            DateTime startDate;
            DateTime endDate;
            DateTime endDateMonth; 
            
            // Сколько дней с начала месяца
            int dayEnd;
            // Сколько рабочих дней в месяце
            int dayEndMonth;
            // Если сотрудник пришел в данном месяце, то сколько дней отработал
            int dayPerson;

            // Вызов метода CalculateAge из класса Settings для подсчета стажа
            rData = Settings.CalculateAge(DateTime.Parse(sDate), DateTime.Parse(tDate));
            // Вычисляем процент за стаж            
            for (int i = 1; i < rData; i++)
            {
                percent += 3;
                if (percent >= 30) percent = 30;
            }
            // Если стажа нет, то процент = 0
            if (rData == 0) percent = 0;
            // Преобразование ставки из string в decimal
            decimal dSalaryRate;
            dSalaryRate = Convert.ToDecimal(salaryRate);

            // Определяем первый день месяца!!!!
            startDate = DateTime.Parse(tDate).AddDays(-(DateTime.Today.Day - 1));
            
            // Дата на начисление зарплаты выбрнанного месяца
            endDate = DateTime.Parse(tDate);
                               
            // Последний день месяца
            endDateMonth = startDate.AddDays(1 - (startDate.Day)).AddMonths(1).AddDays(-1);

            // Сколько дней рабочих в месяце
            dayEndMonth = Settings.BusinessDays(startDate, endDateMonth);

            // Проверяем дату приема на работу для подсчета отработанных дней
            dayPerson = (int)(DateTime.Parse(tDate) - DateTime.Parse(sDate)).Days;
            if (dayPerson < 0) dayPerson = 0;
            if (dayPerson > 31)
            {
                // Сколько дней отработанно
                dayEnd = Settings.GetBusinessDays(startDate, endDate);
            }
            else dayEnd = dayPerson;


            //Вычисляем зарплату
            wagesEmployee = ((dSalaryRate + (dSalaryRate / 100 * percent)) / dayEndMonth) * dayEnd;

            return wagesEmployee;
        }
    }
}
