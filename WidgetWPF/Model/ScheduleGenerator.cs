using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetWPF.Model
{
    public class ScheduleGenerator
    {
        public void GetSchedule()
        {
            int minNumItem = 100;
            int maxNumItem = 1000;

            Random rnd = new();

            int num = rnd.Next(minNumItem, maxNumItem);
        }

    }
}
