using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersCalender.Entities
{
    [Serializable]
    public class Lecture
    {
        public string Teacher { get; set; }
        public string Subject { get; set; }

        public string Room { get; set; }

        public DateTime Date { get; set; }

        public Lecture()
        {
            this.Teacher = null;
            this.Subject = null;
            this.Room = null;
            this.Date = DateTime.Now;
        }

        public Lecture(string teacher, string subject, string room,DateTime date)
        {
            this.Teacher = teacher;
            this.Subject = subject;
            this.Room = room;
            this.Date = date;
        }
    }
}
