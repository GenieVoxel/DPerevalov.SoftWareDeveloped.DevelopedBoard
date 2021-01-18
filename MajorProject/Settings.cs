using System;
using System.Collections.Generic;
using System.Text;

namespace DPerevalov.SoftWareDeveloped.MajorProject
{
    public static class Settings
    {
        /// <summary>
        /// Определяем стаж
        /// </summary>
        public static int CalculateAge(DateTime BeginningDate, DateTime dateTime)
        {
            int YearsPassed = dateTime.Year - BeginningDate.Year;

            if (YearsPassed <= 0)
            {
                if (dateTime.Month < BeginningDate.Month || (dateTime.Month == BeginningDate.Month && dateTime.Day < BeginningDate.Day))
                {
                    YearsPassed--;
                }
            }

            return YearsPassed;
        }

        /// <summary>
        /// Определяем сколько дней отработано
        /// </summary>
        public static int GetBusinessDays(DateTime startData, DateTime endData)
        {
            double calcBusinessDaysTemp;
            int calcBusinessDays;

            calcBusinessDaysTemp = 1 + ((endData - startData).TotalDays * 5 - (startData.DayOfWeek - endData.DayOfWeek) * 2) / 7;

            if (endData.DayOfWeek == DayOfWeek.Saturday) calcBusinessDaysTemp--;
            if (startData.DayOfWeek == DayOfWeek.Sunday) calcBusinessDaysTemp--;

            calcBusinessDays = (int)calcBusinessDaysTemp;

            return calcBusinessDays;
        }

        /// <summary>
        /// Определяем сколько рабочих дней в выбраном месяце
        /// </summary>
        public static int BusinessDays(DateTime startData, DateTime endData)
        {
            double calcBusinessDaysTemp;
            int calcBusinessDays;

            calcBusinessDaysTemp = 1 + ((endData - startData).TotalDays * 5 - (startData.DayOfWeek - endData.DayOfWeek) * 2) / 7;

            if (endData.DayOfWeek == DayOfWeek.Saturday) calcBusinessDaysTemp--;
            if (startData.DayOfWeek == DayOfWeek.Sunday) calcBusinessDaysTemp--;

            calcBusinessDays = (int)calcBusinessDaysTemp;

            return calcBusinessDays;
        }
    }
}
