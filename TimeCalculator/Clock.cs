using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
{
    internal class Clock
    {
        private int time = 0;
        public int Time
        {
            get { return time; }
            set { time = value % 1440; }
        }

        private int hours = 0;
        public string Hours 
        {
            get 
            {
                hours = (Time / 60) % 24;
                return hours.ToString().Length == 1 ? $"0{hours}" : hours.ToString(); 
            }
        }

        private static int minutes = 0;

        public string Minutes
        {
            get 
            {
                minutes = Time % 60;
                return minutes.ToString().Length == 1 ? $"0{minutes}" : minutes.ToString(); 
            }
        }

        public string TimeString
        {
            get { return $"{Hours}{Minutes}"; }
        }

        public void TenHoursUp()
        {
            if (Time <= 839)
            {
                Time += 600;
            }
        }

        public void TenHoursDown()
        {
            if (Time >= 600)
            {
                Time -= 600;
            }
        }

        public void HoursUp()
        {
            if (Time <= 1379)
            {
                Time += 60;
            }
        }

        public void HoursDown()
        {
            if (Time >= 60)
            {
                Time -= 60;
            }
        }

        public void TenMinutesUp()
        {
            if (Time <= 1429)
            {
                Time += 10;
            }
        }

        public void TenMinutesDown()
        {
            if (Time >= 10)
            {
                Time -= 10;
            }
        }

        public void MinutesUp()
        {
            if (Time < 1439)
            {
                Time++;
            }
        }

        public void MinutesDown()
        {
            if (Time > 0)
            {
                Time--;
            }
        }
    }
}
