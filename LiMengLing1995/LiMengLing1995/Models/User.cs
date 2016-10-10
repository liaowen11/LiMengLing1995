using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiMengLing1995.Models
{
    public class User
    {
        public string user { get; set; }
        public string pwd { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Sex { get; set; }
        public bool UserType { get; set; }
        public string Mobile { get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime UpdateTiem { get; set; }
    }
}