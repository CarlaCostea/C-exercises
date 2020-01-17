using System;

namespace Alarm
{
    [Flags]
    enum Days
    {
        None = 0,
        Su = 1,
        Mo = 2,
        Tu = 4,
        We = 8,
        Th = 16,
        Fr = 32,
        Sa = 64
    }

    struct Time
    {
        public int Hour;
        public int Minutes;

        public Time(int hour, int minutes)
        {
            this.Hour = hour;
            this.Minutes = minutes;
        }
    }

    struct Alert
    {
        public Time Time;
        public Days Days;

        public Alert(Time time, Days days = Days.None)
        {
            this.Time = time;
            this.Days = days;
        }
    }

    class Program
    {
        static void Main()
        {
            int countOfAlerts = Convert.ToInt32(Console.ReadLine());
            Alert[] alerts = new Alert[countOfAlerts];

            for (int i = 0; i < alerts.Length; i++)
            {
                alerts[i] = ReadAlert();
            }

            Time timeToCheck = ReadTime();
            Days dayToCheck = GetDay(Console.ReadLine());

            Console.WriteLine(CheckAlarm(alerts, timeToCheck, dayToCheck));
            Console.Read();
        }

        static bool CheckAlarm(Alert[] alerts, Time timeToCheck, Days dayToCheck)
        {
            for (int i = 0; i < alerts.Length; i++)
            {
                if (!CheckAlarmTime(alerts[i].Time, timeToCheck))
                {
                    continue;
                }

                if (CheckAlarmDay(alerts[i].Days, dayToCheck))
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckAlarmDay(Days days, Days dayToCheck)
        {
            return (days & dayToCheck) != 0;
        }

        static bool CheckAlarmTime(Time time, Time timeToCheck)
        {
            return time.Hour == timeToCheck.Hour && time.Minutes == timeToCheck.Minutes;
        }

        static Alert ReadAlert()
        {
            Alert result = new Alert(ReadTime());

            string[] days = Console.ReadLine().Split(' ');
            for (int i = 0; i < days.Length; i++)
            {
                AddDayToAlert(ref result, GetDay(days[i]));
            }

            return result;
        }

        static Time ReadTime()
        {
            string[] time = Console.ReadLine().Split(':');
            return new Time(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]));
        }

        static void AddDayToAlert(ref Alert result, Days day)
        {
            result.Days = result.Days | day;
        }

        static Days GetDay(string day)
        {
            switch (day)
            {
                case "Mo":
                    return Days.Mo;
                case "Tu":
                    return Days.Tu;
                case "We":
                    return Days.We;
                case "Th":
                    return Days.Th;
                case "Fr":
                    return Days.Fr;
                case "Sa":
                    return Days.Sa;
            }

            return Days.Su;
        }
    }
}
