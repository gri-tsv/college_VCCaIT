using System;

namespace Calculations
{
    public class CalculationsLib
    {
        public string AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {

            TimeSpan common = new TimeSpan(0, consultationTime, 0);
            int get_isklucheniya = 0;
            while (beginWorkingTime <= (endWorkingTime - common))
            {

                if (beginWorkingTime == startTimes[get_isklucheniya])
                {
                    Console.WriteLine("got you");
                    beginWorkingTime += TimeSpan.FromMinutes(durations[get_isklucheniya]);
                    string local_res = (beginWorkingTime + "-" + (beginWorkingTime + common));
                    beginWorkingTime += common;
                    get_isklucheniya += 1;
                    return local_res;
                }
                else
                {
                    Console.WriteLine(beginWorkingTime + "-" + (beginWorkingTime + common));
                    string local_res = (beginWorkingTime + "-" + (beginWorkingTime + common));
                    beginWorkingTime += common;
                    return local_res;
                }

            }

            return "Completed";
        }
    }
}
