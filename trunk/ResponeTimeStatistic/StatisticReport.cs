using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponeTimeStatistic
{
    class StatisticReport
    {
        /*
           List<Request> list : danh sach cac request chua thong tin
         * int duration : thoi gian (ms) cho moi level
         * */
        public static List<double> StatisticByLevel(List<Request> list, int duration, int NumberOfLevel)
        {
            if (list.Count == 0) return null;
            list = list.Where(x => x.ResponeStatus.Equals("OK")).ToList();
            long start = list.ElementAt(0).StartTime;
            List<double> res = new List<double>();
            int i = NumberOfLevel+1;
            while (--i>0)
            {
               var lv = list.Where(x => x.StartTime+x.ResponeTime >=start && x.StartTime+x.ResponeTime < start+duration);
                int count = lv.Count();
               int count1 = lv.Where(x => x.ResponeTime > 50000).Count();
               var wrong = lv.Where(x => x.ResponeTime > 50000).Select((item,index)=>index+"-"+item.ResponeTime);
                double avg = lv.Average(x => x.ResponeTime);
                res.Add(avg);
                var s = list.Where(x => x.StartTime >= start + duration).FirstOrDefault();
                if (s != null)
                {
                    start = s.StartTime;
                }
                else {
                    break;
                }
            }
            return res;
        }
        public static List<double> ErrorPercentByLevel(List<Request> list, int duration, int NumberOfLevel) {
            if (list.Count == 0) return null;
          
            long start = list.ElementAt(0).StartTime;
            List<double> res = new List<double>();
            int i = NumberOfLevel + 1;
            while (--i > 0)
            {
                var lv = list.Where(x => x.StartTime + x.ResponeTime >= start && x.StartTime + x.ResponeTime < start + duration);
                int count = lv.Count();
                int successCount = lv.Where(x => x.ResponeStatus.Equals("OK")).Count();
                double errPercent = Math.Round(1 - (successCount * 1.0 / count),4)*100;
                res.Add(errPercent);
                var s = list.Where(x => x.StartTime >= start + duration).FirstOrDefault();
                if (s != null)
                {
                    start = s.StartTime;
                }
                else
                {
                    break;
                }
            }
            return res;
        }
        public static List<Request> NormalizeFile(List<Request> list, int duration, int NumberOfLevel)
        {
            return null;
        }
    }
}
