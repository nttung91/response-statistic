using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponeTimeStatistic
{
    public class Request
    {
        private long _StartTime, _ResponeTime;
        string _ResponeStatus;
        public Request(long starttime, long responetime, string responestatus) {
            this._StartTime = starttime;
            this._ResponeTime = responetime;
            this._ResponeStatus = responestatus;
        }
        public long StartTime {
            get {return _StartTime;} 
            set {_StartTime = value;} 
        }
        public long ResponeTime
        {
            get { return _ResponeTime; }
            set { _ResponeTime = value; } 
        }
        public string ResponeStatus
        {
            get { return _ResponeStatus; }
            set { _ResponeStatus = value; }
        }

    }
}
