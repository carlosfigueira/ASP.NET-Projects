using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwimmingTracker.Models
{
    public static class SessionRepository
    {
        static List<Session> Sessions;

        static SessionRepository()
        {
            Sessions = new List<Session>();

            #region 2012
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 3, 19, 9, 24, 0, DateTimeKind.Local),
                Duration = "0:50:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:20",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:00",
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:20",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:10",
                    },
                    new Set {
                        DistanceYards = 250,
                        Style = Style.Freestyle,
                        Duration = "4:40",
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                        Duration = "1:15",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 3, 16, 12, 16, 0, DateTimeKind.Local),
                Duration = "0:44:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:30",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:00",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:10",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:30",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:15",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 3, 12, 11, 40, 0, DateTimeKind.Local),
                Duration = "0:40:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:05",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:15",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:10",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:20",
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                        Duration = "6:40",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 3, 1, 16, 30, 0, DateTimeKind.Local),
                Duration = "0:40:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:50",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:45",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:50",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:25",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                        Duration = "2:00",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 2, 20, 20, 46, 0, DateTimeKind.Local),
                Duration = "0:44:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:45",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:10",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:15",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:10",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:10",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:30",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 2, 17, 6, 27, 0, DateTimeKind.Local),
                Duration = "0:51:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:55",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:40",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:40",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:40",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:35",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:20",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 2, 2, 16, 46, 0, DateTimeKind.Local),
                Duration = "0:47:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:10",
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:40",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:10",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                        Duration = "3:25",
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                        Duration = "1:00",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 1, 30, 21, 26, 0, DateTimeKind.Local),
                Duration = "0:36:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:25",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:25",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:10",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:10",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                        Duration = "3:35",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 1, 26, 15, 59, 0, DateTimeKind.Local),
                Duration = "0:45:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:15",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:15",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:10",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:15",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:25",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 1, 23, 21, 09, 0, DateTimeKind.Local),
                Duration = "0:42:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:10",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:30",
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:50",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                        Duration = "2:20",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 1, 14, 10, 16, 0, DateTimeKind.Local),
                Duration = "0:34:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:25",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:00",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 1, 11, 11, 53, 0, DateTimeKind.Local),
                Duration = "0:42:00",
                Sets = new List<Set>
                {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:40",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:40",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "8:35",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:30",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 01, 09, 21, 39, 0, DateTimeKind.Local),
                Duration = "0:40:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:58",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "8:30",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 01, 06, 16, 10, 0, DateTimeKind.Local),
                Duration = "0:39:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2012, 01, 04, 21, 11, 0, DateTimeKind.Local),
                Duration = "0:35:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:45",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:40",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            #endregion

            #region 2011
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 12, 29, 07, 29, 0, DateTimeKind.Local),
                Duration = "0:36:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:25",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 09, 02, 17, 57, 0, DateTimeKind.Local),
                Duration = "0:43:30",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1900,
                        Style = Style.OpenWater,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 08, 18, 16, 18, 0, DateTimeKind.Local),
                Duration = "0:38:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:55",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 08, 12, 17, 54, 0, DateTimeKind.Local),
                Duration = "0:48:26",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 2376,
                        Style = Style.OpenWater,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 08, 05, 18, 25, 0, DateTimeKind.Local),
                Duration = "0:48:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 2323,
                        Style = Style.OpenWater,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 08, 03, 11, 29, 0, DateTimeKind.Local),
                Duration = "0:50:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:35",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:50",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 07, 15, 11, 38, 0, DateTimeKind.Local),
                Duration = "0:44:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:35",
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "19:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:30",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                        Duration = "1:30",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 07, 13, 12, 05, 0, DateTimeKind.Local),
                Duration = "0:45:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:25",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                        Duration = "4:30",
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "8:50",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 07, 06, 18, 11, 0, DateTimeKind.Local),
                Duration = "0:48:30",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:25",
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 07, 01, 17, 22, 0, DateTimeKind.Local),
                Duration = "0:45:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:30",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:50",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 06, 13, 20, 59, 0, DateTimeKind.Local),
                Duration = "0:40:30",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:10",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:25",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                        Duration = "1:35",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 06, 07, 17, 57, 0, DateTimeKind.Local),
                Duration = "0:46:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:25",
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "19:00",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 05, 27, 16, 14, 0, DateTimeKind.Local),
                Duration = "0:34:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:30",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:10",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                        Duration = "1:32",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 05, 23, 21, 33, 0, DateTimeKind.Local),
                Duration = "0:42:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:53",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:05",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 05, 13, 21, 03, 0, DateTimeKind.Local),
                Duration = "0:37:30",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:17",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                        Duration = "9:05",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 05, 11, 21, 22, 0, DateTimeKind.Local),
                Duration = "0:44:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:28",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "19:00",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 04, 28, 15, 31, 0, DateTimeKind.Local),
                Duration = "0:39:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:35",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 04, 25, 16, 02, 0, DateTimeKind.Local),
                Duration = "0:47:30",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 04, 21, 16, 55, 0, DateTimeKind.Local),
                Duration = "0:46:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 04, 13, 21, 09, 0, DateTimeKind.Local),
                Duration = "0:43:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "16:50",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                        Duration = "1:53",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2011, 03, 28, 11, 52, 0, DateTimeKind.Local),
                Duration = "0:43:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:25",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            #endregion

            #region 2010
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 12, 08, 20, 48, 0, DateTimeKind.Local),
                Duration = "0:41:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 11, 05, 12, 46, 0, DateTimeKind.Local),
                Duration = "0:41:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 10, 26, 16, 31, 0, DateTimeKind.Local),
                Duration = "0:38:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:05",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 10, 12, 11, 58, 0, DateTimeKind.Local),
                Duration = "0:43:45",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:30",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 10, 07, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:25:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                        Duration = "3:50",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 09, 24, 11, 36, 0, DateTimeKind.Local),
                Duration = "0:40:35",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:15",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                        Duration = "1:36",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 09, 17, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:39:45",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "17:50",
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 08, 27, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:20:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 800,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 08, 19, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:30:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:05",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                        Duration = "1:43",
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 08, 12, 16, 21, 0, DateTimeKind.Local),
                Duration = "0:32:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                        Duration = "18:00",
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 08, 06, 17, 20, 0, DateTimeKind.Local),
                Duration = "0:32:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                        Duration = "3:45",
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 07, 26, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:35:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 07, 08, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:30:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1050,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 150,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 07, 01, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:30:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 05, 26, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:21:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 05, 16, 21, 00, 0, DateTimeKind.Local),
                Duration = "0:25:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2010, 05, 11, 16, 20, 0, DateTimeKind.Local),
                Duration = "0:30:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                }
            });
            #endregion

            #region 2009
            Sessions.Add(new Session
            {
                Date = new DateTime(2009, 06, 03, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:20:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2009, 01, 08, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:22:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            #endregion

            #region 2008
            Sessions.Add(new Session
            {
                Date = new DateTime(2008, 08, 11, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2008, 06, 24, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:22:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            #endregion

            #region 2007
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 07, 24, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:40:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 500,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 07, 22, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:18:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 900,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 07, 12, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:50:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 07, 04, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:44:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 1000,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 06, 28, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:36:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 06, 25, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:32:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 06, 21, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:30:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 06, 19, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 06, 12, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:22:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 04, 24, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 04, 12, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:26:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 04, 10, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 03, 20, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:26:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 03, 07, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 02, 23, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:22:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 01, 15, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2007, 01, 09, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:20:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            #endregion

            #region 2006
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 10, 30, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:20:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 08, 22, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 07, 20, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:25:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 07, 07, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:25:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Medley,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 06, 21, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:25:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 06, 15, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:24:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 06, 09, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:22:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 25,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 06, 06, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:22:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 400,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Butterfly,
                    },
                    new Set {
                        DistanceYards = 50,
                        Style = Style.Backstroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                }
            });
            Sessions.Add(new Session
            {
                Date = new DateTime(2006, 06, 01, 00, 00, 0, DateTimeKind.Local),
                Duration = "0:20:00",
                Sets = new List<Set> {
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 200,
                        Style = Style.Freestyle,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Breaststroke,
                    },
                    new Set {
                        DistanceYards = 100,
                        Style = Style.Medley,
                    },
                }
            });
            #endregion
        }

        public static ICollection<Session> GetSessions()
        {
            return Sessions.AsReadOnly();
        }
    }
}