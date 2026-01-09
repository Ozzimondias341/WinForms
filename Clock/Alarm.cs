using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Clock
{
    public class Alarm
    {

        public bool IsEnabled { get; set; }
        public AlarmSchedule Schedule { get; }
        public WindowsMediaPlayer AlarmMelody { get; } 
       
    }
    public class AlarmSchedule
    {
        public DateTime AlarmTime { get; set; }
        public DayOfWeek[] daysOfWeek;


        public bool IsMatch()
        {
            if (daysOfWeek.Length == 0)
            {
                if (AlarmTime == DateTime.Now)
                {
                    return true;
                }
            }
            else
            {
                if (daysOfWeek.Contains(DateTime.Now.DayOfWeek))
                {
                    if (AlarmTime.Hour == DateTime.Now.Hour && AlarmTime.Minute == DateTime.Now.Minute)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
