using System;
using System.Collections.Generic;

namespace Task
{
  public static class AttendanceData
  {
        /*attendance records for 4 days 2020/6/21 to 2020/6/24*/
        public static readonly List<AttendanceRecordModel> attendanceRecords = new List<AttendanceRecordModel>() {
            new AttendanceRecordModel{                      // day1 2020/6/21
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,21,8,57,23),
                CheckOut=new DateTime(2020,6,21,18,2,34)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,21,9,30,45),
                CheckOut=new DateTime(2020,6,21,13,3,12)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,21,14,5,23),
                CheckOut=new DateTime(2020,6,21,19,5,31)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,21,9,30,45),
                CheckOut=new DateTime(2020,6,21,11,35,12)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,21,11,45,23),
                CheckOut=new DateTime(2020,6,21,13,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,21,14,30,45),
                CheckOut=new DateTime(2020,6,21,19,11,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,21,9,10,45),
                CheckOut=new DateTime(2020,6,21,11,5,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,21,11,30,23),
                CheckOut=new DateTime(2020,6,21,13,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,21,14,10,45),
                CheckOut=new DateTime(2020,6,21,15,50,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,21,16,5,45),
                CheckOut=new DateTime(2020,6,21,18,1,12)
            },
            new AttendanceRecordModel{                      // day2 2020/6/22
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,22,9,5,23),
                CheckOut=new DateTime(2020,6,22,13,2,34)
            },
            new AttendanceRecordModel{
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,22,14,5,23),
                CheckOut=new DateTime(2020,6,22,18,23,34)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,22,9,3,45),
                CheckOut=new DateTime(2020,6,22,11,3,12)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,22,11,15,23),
                CheckOut=new DateTime(2020,6,22,12,55,31)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,22,14,1,45),
                CheckOut=new DateTime(2020,6,22,16,35,12)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,22,16,47,23),
                CheckOut=new DateTime(2020,6,22,18,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,22,9,3,45),
                CheckOut=new DateTime(2020,6,22,11,5,12)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,22,11,25,23),
                CheckOut=new DateTime(2020,6,22,13,40,34)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,22,14,15,45),
                CheckOut=new DateTime(2020,6,22,18,11,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,22,10,5,23),
                CheckOut=new DateTime(2020,6,22,13,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,22,14,30,45),
                CheckOut=new DateTime(2020,6,22,19,11,12)
            },
            new AttendanceRecordModel{                      // day3 2020/6/23
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,23,9,5,23),
                CheckOut=new DateTime(2020,6,23,13,2,34)
            },
            new AttendanceRecordModel{
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,23,14,5,23),
                CheckOut=new DateTime(2020,6,23,16,23,34)
            },
            new AttendanceRecordModel{
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,23,16,35,23),
                CheckOut=new DateTime(2020,6,23,18,9,34)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,23,9,3,45),
                CheckOut=new DateTime(2020,6,23,11,3,12)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,23,11,15,23),
                CheckOut=new DateTime(2020,6,23,12,55,31)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,23,14,1,45),
                CheckOut=new DateTime(2020,6,23,16,35,12)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,23,16,47,23),
                CheckOut=new DateTime(2020,6,23,18,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,23,9,3,45),
                CheckOut=new DateTime(2020,6,23,11,5,12)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,23,11,25,23),
                CheckOut=new DateTime(2020,6,23,13,24,34)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,23,14,15,45),
                CheckOut=new DateTime(2020,6,23,16,11,12)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,23,16,25,45),
                CheckOut=new DateTime(2020,6,23,18,47,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,23,8,45,23),
                CheckOut=new DateTime(2020,6,23,12,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,23,13,30,45),
                CheckOut=new DateTime(2020,6,23,18,17,12)
            },
            new AttendanceRecordModel{                      // day4 2020/6/24
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,24,8,50,23),
                CheckOut=new DateTime(2020,6,24,12,45,34)
            },
            new AttendanceRecordModel{
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,24,13,35,23),
                CheckOut=new DateTime(2020,6,24,16,5,34)
            },
            new AttendanceRecordModel{
                EmployeeId=1,
                EmployeeName="Sujan",
                CheckIn=new DateTime(2020,6,24,16,25,23),
                CheckOut=new DateTime(2020,6,24,18,1,34)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,24,9,3,45),
                CheckOut=new DateTime(2020,6,24,12,30,12)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,24,13,15,23),
                CheckOut=new DateTime(2020,6,24,16,55,31)
            },
            new AttendanceRecordModel{
                EmployeeId=2,
                EmployeeName="Ramesh",
                CheckIn=new DateTime(2020,6,24,17,5,45),
                CheckOut=new DateTime(2020,6,24,18,35,12)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,24,9,30,45),
                CheckOut=new DateTime(2020,6,24,11,50,12)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,24,12,25,23),
                CheckOut=new DateTime(2020,6,24,15,24,34)
            },
            new AttendanceRecordModel{
                EmployeeId=3,
                EmployeeName="Sachet",
                CheckIn=new DateTime(2020,6,24,16,5,45),
                CheckOut=new DateTime(2020,6,24,19,11,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,24,8,45,23),
                CheckOut=new DateTime(2020,6,24,12,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,24,13,10,45),
                CheckOut=new DateTime(2020,6,24,15,17,12)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,24,15,30,23),
                CheckOut=new DateTime(2020,6,24,17,25,34)
            },
            new AttendanceRecordModel{
                EmployeeId=4,
                EmployeeName="Rupesh",
                CheckIn=new DateTime(2020,6,24,17,42,45),
                CheckOut=new DateTime(2020,6,24,18,59,12)
            }
        };
    }
}
