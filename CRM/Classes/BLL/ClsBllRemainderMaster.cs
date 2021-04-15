using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace CRM
{
        class ClsBllRemainderMaster
        {
                ClsDalRemainderMaster ObjDal = new ClsDalRemainderMaster();

                private Int32 _RemainderId;
                public Int32 RemainderId
                {
                        get { return _RemainderId; }
                        set { _RemainderId = value; }
                }

                private string _Name;
                public string Name
                {
                        get { return _Name; }
                        set { _Name = value; }
                }

                private int _PriorityId;
                public int PriorityId
                {
                        get { return _PriorityId; }
                        set { _PriorityId = value; }
                }

                private string _Message;
                public string Message
                {
                        get { return _Message; }
                        set { _Message = value; }
                }

                private DateTime _StartTime;
                public DateTime StartTime
                {
                        get { return _StartTime; }
                        set { _StartTime = value; }
                }

                private DateTime _StopTime;
                public DateTime StopTime
                {
                        get { return _StopTime; }
                        set { _StopTime = value; }
                }

                private int _Intervals;
                public int Intervals
                {
                        get { return _Intervals; }
                        set { _Intervals = value; }
                }

                private string _Days;
                public string Days
                {
                        get { return _Days; }
                        set { _Days = value; }
                }

                private string _ApplicableUsers;
                public string ApplicableUsers
                {
                        get { return _ApplicableUsers; }
                        set { _ApplicableUsers = value; }
                }

                public DataTable ReturnDT(int flag)
                {
                        return ObjDal.ReturnDT(this, flag);
                }

                public void Save(int flag)
                {
                        ObjDal.Save(this, flag);
                }

                public void Delete(int flag)
                {
                        ObjDal.Delete(this, flag);
                }

        }
}
