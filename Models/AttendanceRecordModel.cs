using System;

namespace Task
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
    public class AttendanceRecordModel:EmployeeModel
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }

    public class WorkingHoursModel:EmployeeModel
    {
        public double WorkingHours { get; set; }
        public string WorkingDate { get; set; }
    }
}
