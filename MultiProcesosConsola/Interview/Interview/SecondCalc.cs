using System;
//return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
//var t = TimeSpan.FromSeconds(seconds);
//return string.Format("{0:00}:{1:00}:{2:00}", (int) t.TotalHours, t.Minutes, t.Seconds);
namespace Interview
{
    class SecondCalc
    {
        public static string GetReadableTime(int seconds)
        {
            int horas=0, minutos=0, segundos=0;
            string final = "";
            while(seconds>0)
            {
                if (seconds < 60)
                {
                    segundos = seconds;
                    seconds = 0;
                    //fecha = fecha.AddSeconds(second);
                }
                else if (seconds >= 60 && seconds < 3600)
                {
                    while (seconds >= 60)
                    {
                        seconds = seconds - 60;
                        minutos++;
                    }
                    //fecha = fecha.AddMinutes(second / 60);
                }
                else if (seconds >= 3600)
                {
                    while(seconds>=3600)
                    {
                        seconds = seconds - 3600;
                        horas++;
                    }
                    //fecha = fecha.AddHours(second / 3600);
                }
            }
            TimeSpan fecha = new TimeSpan(horas, minutos, segundos);
            if (horas >= 24)
            {
                return horas + ":" + minutos.ToString("D2") + ":" + segundos.ToString("D2");
            }
            final = fecha.ToString();
            return final;
        }
    }
}
