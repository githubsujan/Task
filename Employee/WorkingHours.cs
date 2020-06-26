using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
  public static class WorkingHours
  {
        public static void GetMinimumAverageHours()
        {
            ShowAttendanceRecords();
            var listConsecutiveWorkingHours = GetConsecutiveWorkingHours();
            ShowConsecutiveWorkingHours(listConsecutiveWorkingHours);
            var listTotalWorkingHours=GetTotalWorkingHours(listConsecutiveWorkingHours);
            CalculateMinimumAverageWorkingHours(listTotalWorkingHours);
        }

        /*Shows all attendance records*/
        public static void ShowAttendanceRecords()
        {
            Console.WriteLine("************************Employees Attendance Records****************************");
            Console.WriteLine("Employee Id " + " Employee Name " + " Check In               " + "    Check Out ");
            Console.WriteLine("=========== " + " ============= " + " ====================== " + "    ========= ");

            foreach (var item in AttendanceData.attendanceRecords)
            {
                Console.WriteLine(item.EmployeeId + "            " + item.EmployeeName + "          " + item.CheckIn + "       " + item.CheckOut);
            }
        }

        /*Get Working Hours Between Consecutive CheckIn/CheckOut per day*/
        public static List<WorkingHoursModel> GetConsecutiveWorkingHours()
        {
            List<WorkingHoursModel> listConsecutiveWorkingHours = new List<WorkingHoursModel>();
            foreach (var item in AttendanceData.attendanceRecords)
            {
                TimeSpan differenceCheckinCheckout = item.CheckOut - item.CheckIn;
                listConsecutiveWorkingHours.Add(new WorkingHoursModel
                {
                    EmployeeId = item.EmployeeId,
                    EmployeeName = item.EmployeeName,
                    WorkingHours = Math.Round(differenceCheckinCheckout.TotalMinutes / 60, 2),
                    WorkingDate = item.CheckIn.ToShortDateString()
                });
            }
            return listConsecutiveWorkingHours;
        }

        /*Show Working Hours Between Consecutive CheckIn/CheckOut per day*/
        public static void ShowConsecutiveWorkingHours(List<WorkingHoursModel> listConsecutiveWorkingHours)
        {
            Console.WriteLine("======================================================================================================================");
            Console.WriteLine("******************Working Hours Between Consecutive CheckIn/CheckOut per day*******************");
            Console.WriteLine("Employee Id " + " Employee Name " + " Working Hours " + " Working Date ");
            Console.WriteLine("=========== " + " ============= " + " ============= " + " ============ ");

            foreach (var item in listConsecutiveWorkingHours)
            {
                Console.WriteLine(item.EmployeeId + "              " + item.EmployeeName + "            " + item.WorkingHours + "       " + item.WorkingDate);
            }
        }

        /*Total Working Hours Per Day*/
        public static List<WorkingHoursModel> GetTotalWorkingHours(List<WorkingHoursModel> listConsecutiveWorkingHours)
        {
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("***********************Total Working Hours per day**********************************");
            Console.WriteLine("Employee Id " + " Employee Name " + " Date          " + " Total Hours ");
            Console.WriteLine("=========== " + " ============= " + " ========          " + " =========== ");

            var distinctEmployeeIdName = listConsecutiveWorkingHours.Select(x => new { id=x.EmployeeId,name=x.EmployeeName }).Distinct();
            List<WorkingHoursModel> listTotalWorkingHours = new List<WorkingHoursModel>();
            foreach (var item in distinctEmployeeIdName)
            {
                var listTotalHoursPerDay = listConsecutiveWorkingHours.Where(x => x.EmployeeId == item.id).GroupBy(x => x.WorkingDate).Select(x => new { date = x.Key, hours = x.Sum(x => x.WorkingHours) });
                foreach (var element in listTotalHoursPerDay)
                {
                    listTotalWorkingHours.Add(new WorkingHoursModel
                    {
                        EmployeeId=item.id,
                        EmployeeName=item.name,
                        WorkingHours=element.hours,
                        WorkingDate=element.date
                    });
                    Console.WriteLine(item.id + "            " + item.name + "         " + element.date + "          " + element.hours);
                }
            }
            return listTotalWorkingHours;
        }
        
        /*Calculate minimum average working hours*/
        public static void CalculateMinimumAverageWorkingHours(List<WorkingHoursModel> listTotalWorkingHours)
        {
            Console.WriteLine("============================================================================================================================================");
            Console.WriteLine("************************Average Working Hours************************");
            Console.WriteLine("Employee Id " + " Average Working Hours");
            Console.WriteLine("=========== " + " =====================");

            var listAverageWorkingHours = listTotalWorkingHours.GroupBy(x => x.EmployeeId).Select(x => new { id=x.Key, average=x.Average(x => x.WorkingHours) });
            foreach(var item in listAverageWorkingHours)
            {
                Console.WriteLine(item.id + "               " + item.average);
            }

            var minimumAverageHours = listAverageWorkingHours.Min(x=>x.average);
            var employeeId = listAverageWorkingHours.First(x => x.average == minimumAverageHours).id;
            var employeeName = listTotalWorkingHours.First(x => x.EmployeeId == employeeId).EmployeeName;

            Console.WriteLine("=============================================================================================================================================");
            Console.WriteLine("************Employee with minimum average working hours*****************");
            Console.WriteLine("Employee Id " + " Employee Name " + " Minimum Average Working Hours");
            Console.WriteLine("=========== " + " ============= " + " =============================");
            Console.WriteLine(employeeId + "              " + employeeName + "           "+ minimumAverageHours);
        }
    }
}