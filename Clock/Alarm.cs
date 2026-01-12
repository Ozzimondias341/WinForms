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
        public string AlarmMelody { get; }

        public Alarm(AlarmSchedule schedule, string path_To_Melody)
        {
            AlarmMelody = path_To_Melody;
            Schedule = schedule;
        }

        public void Trigger(AlarmTriggerDialog dialog)
        {
            if (Schedule.IsNeededToTrigger())
            {
                dialog.Show();
            }
        }
    }
    public class AlarmSchedule
    {
        public DateTime AlarmTime { get; set; }
        public DayOfWeek[] daysOfWeek;
        public AlarmMode Mode { get; set; }


        public AlarmSchedule(DateTime alarmTime, DayOfWeek[] daysOfWeek, AlarmMode mode)
        {
            AlarmTime = alarmTime;
            this.daysOfWeek = daysOfWeek;
            Mode = mode;
        }

        public bool IsNeededToTrigger()
        {
            if (IsDayMatch() && IsTimeMatch()) return true;

            return false;
        }



        public bool IsTimeMatch()
        {
            if (AlarmTime.Hour == DateTime.Now.Hour && AlarmTime.Minute == DateTime.Now.Minute) return true;
            return false;
        }

        public bool IsDayMatch()
        {
            switch (Mode)
            {
                case AlarmMode.Weekdays:
                    if (daysOfWeek.Length > 0 && daysOfWeek.Contains(DateTime.Now.DayOfWeek)) return true;
                    break;
                case AlarmMode.Date:
                    if (AlarmTime.Year == DateTime.Now.Year && AlarmTime.Month == DateTime.Now.Month && AlarmTime.Day == DateTime.Now.Day) return true;
                    break;
                case AlarmMode.Everyday:
                    return true;
            }
            return false;
        }


    }
    public enum AlarmMode
    {
        Weekdays,
        Date, 
        Everyday
    }

    
}
