using System;
using System.Data;
using System.Data.SqlClient;

namespace Application
{
    public class code1
    {
        static void Main(string[] args)
        {
            //DataSet dsShifts = null;
            //SqlParameter[] _objectSqlParmeters = null;
            
            Console.WriteLine("Hello World!");
        }
        public void newFunc()
        {
            //DateTime ShiftDateFilter = DateTime.Now;
            //string ShiftStartTimeFilter = string.Empty;
            //string ShiftEndTimeFilter = string.Empty;
            //string selectedShift = "11/20/2024(19:00 to 6:00)";
            //if (selectedShift != string.Empty)
            //{
            //    string[] SplitFilterDate;
            //    //SplitFilterDate = selectedShift.Split('/');
            //    SplitFilterDate = selectedShift.Split('t');
            //    string SplitStringddmm = string.Empty;
            //    //SplitStringddmm = SplitFilterDate[0] + '/' + SplitFilterDate[1] + "/" + SplitFilterDate[2];
            //    SplitStringddmm = SplitFilterDate[0] + 't' + SplitFilterDate[1];
            //    //ShiftDateFilter = Convert.ToDateTime(SplitStringddmm);
            //    //ShiftDateFilter = ShiftDateFilter.Date;
            //    //ShiftDateFilter = Convert.ToDateTime(SplitFilterDate[0]);
            //    ShiftDateFilter = ShiftDateFilter.Date;
            //    //ShiftStartTimeFilter = SplitFilterDate[3];
            //    //ShiftEndTimeFilter = SplitFilterDate[4]; 
            //    ShiftStartTimeFilter = (SplitFilterDate[0] );
            //    ShiftEndTimeFilter = (SplitFilterDate[1]);
            //    Console.WriteLine(ShiftStartTimeFilter);
            //    Console.WriteLine(ShiftEndTimeFilter);

            //    // ShiftEndTimeFilter = (Convert.ToInt32(ShiftEndTimeFilter.Split(':')[0]) + 1).ToString() + ":00";
            //}

            DateTime dt = new DateTime();

           

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            DateTime cdt = new DateTime();
            cdt =currentDateTime.AddHours(5);
            Console.WriteLine(cdt);
            DateTime negDT = DateTime.Now;
            negDT = negDT.AddHours(-2);
            Console.WriteLine(negDT);
            

            DateTime dt3 = new DateTime(2024, 02, 4, 5, 10, 20);
            Console.WriteLine(dt3);
            dt3.AddHours(5);
            Console.WriteLine(dt3);
        }
    }
}

