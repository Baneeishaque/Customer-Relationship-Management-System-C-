using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CRM
{
        class ClsBllSeviceScheduleMaster
        {
                ClsDalSeviceScheduleMaster objdal = new ClsDalSeviceScheduleMaster();
                private string _Number;
                public string Number
                {
                        get { return _Number; }
                        set { _Number = value; }

                }
                private DateTime _Date;
                public DateTime Date
                {
                        get { return _Date; }
                        set { _Date = value; }

                }
                private string _RegisterNo;
                public string RegisterNo
                {
                        get { return _RegisterNo; }
                        set { _RegisterNo = value; }

                }
                private string _CustomerName;
                public string CustomerName
                {
                        get { return _CustomerName; }
                        set { _CustomerName = value; }

                }
                private string _Address;
                public string Address
                {
                        get { return _Address; }
                        set { _Address = value; }

                }
                private string _PhoneNumber;
                public string PhoneNumber
                {
                        get { return _PhoneNumber; }
                        set { _PhoneNumber = value; }
                }
                private string _ProductName;
                public string ProductName
                {
                        get { return _ProductName; }
                        set { _ProductName = value; }

                }
                private string _ServiceName;
                public string ServiceName
                {
                        get { return _ServiceName; }
                        set { _ServiceName = value; }

                }
                private string _DeliveryDate;
                public string DeliveryDate
                {
                        get { return _DeliveryDate; }
                        set { _DeliveryDate = value; }

                }
                private Int32 _CustomerDetailsId;
                public Int32 CustomerDetailsId
                {
                        get { return _CustomerDetailsId; }
                        set { _CustomerDetailsId = value; }

                }
                private Int32 _SeviceDetailsId;
                public Int32 SeviceDetailsId
                {
                        get { return _SeviceDetailsId; }
                        set { _SeviceDetailsId = value; }

                }
                private Int32 _CustomerId;
                public Int32 CustomerId
                {
                        get { return _CustomerId; }
                        set { _CustomerId = value; }

                }
                private Int32 _RegistrationId;
                public Int32 RegistrationId
                {
                        get { return _RegistrationId; }
                        set { _RegistrationId = value; }

                }
                private Int32 _ProductId;
                public Int32 ProductId
                {
                        get { return _ProductId; }
                        set { _ProductId = value; }

                }
                private Int32 _ServiceId;
                public Int32 ServiceId
                {

                        get { return _ServiceId; }
                        set { _ServiceId = value; }

                }
                private Int32 _ScheduleId;
                public Int32 ScheduleId
                {
                        get { return _ScheduleId; }
                        set { _ScheduleId = value; }
                }

                private Int32 _ScheduleDetailsId;
                public Int32 ScheduleDetailsId
                {
                        get { return _ScheduleDetailsId; }
                        set { _ScheduleDetailsId = value; }
                }

                private string _ScheduleNo;
                public string ScheduleNo
                {
                        get { return _ScheduleNo; }
                        set { _ScheduleNo = value; }
                }

                private Int32 _EmployeeId;
                public Int32 EmployeeId
                {
                        get { return _EmployeeId; }
                        set { _EmployeeId = value; }


                }
                private DataTable _MyTable;
                public DataTable MyTable
                {
                        get { return _MyTable; }
                        set { _MyTable = value; }

                }

                public DataTable returndatatable(int flag)
                {
                        return objdal.returndatatable(this, flag);

                }
                public void Save(int flag)
                {
                        objdal.SaveServiceSchedule(this, flag);


                }
                public int NextNumber()
                {
                        return objdal.nextnumber(this);

                }
                private string _EmpName;
                public string EmpName
                {
                        get { return _EmpName; }
                        set { _EmpName = value; }
                }

                public void Delete(int flag)
                {
                        objdal.Delete(this, flag);
                }

        }
}
