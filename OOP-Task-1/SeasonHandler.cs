using Assignment01_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_1
{
    static class SeasonHandler
    {
        public static string GetSeasonRange(Season season)
        {
            return season switch
            {
                Season.Spring => "March to May",
                Season.Summer => "June to August",
                Season.Autumn => "September to November",
                Season.Winter => "December to February",
                _ => "Unknown"
            };
        }
    }
}
