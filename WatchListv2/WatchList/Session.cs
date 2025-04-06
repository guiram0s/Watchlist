using System;
using System.Collections.Generic;
using System.Text;

namespace WatchList
{
    public static class Session
    {
        public static bool LoggedIn { get; set; } 
        public static string UserName { get; set; }
        public static string Id { get; set; }

    }
}
