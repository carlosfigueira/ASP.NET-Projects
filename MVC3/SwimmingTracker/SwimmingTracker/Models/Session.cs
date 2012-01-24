using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace SwimmingTracker.Models
{
    public class Session
    {
        public DateTime Date { get; set; }
        public string Duration { get; set; }
        public List<Set> Sets { get; set; }
        public string DateString
        {
            get { return this.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture); }
            set { }
        }

        public int TotalDistanceYards
        {
            get
            {
                int result = 0;
                if (this.Sets != null)
                {
                    foreach (var set in this.Sets)
                    {
                        result += set.DistanceYards;
                    }
                }

                return result;
            }
        }
    }

    public class Set
    {
        [Range(25, int.MaxValue)]
        public int DistanceYards { get; set; }
        public Style Style { get; set; }
        public string Duration { get; set; }
    }

    public enum Style
    {
        Butterfly,
        Backstroke,
        Breaststroke,
        Freestyle,
        Medley,
        OpenWater,
    }
}