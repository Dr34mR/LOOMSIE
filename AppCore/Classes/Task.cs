using System;

namespace AppCore.Classes
{
    public class Task
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string Number { get; set; }

        public string Offence { get; set; }

        public DateTime DateReported { get; set; }

        public DateTime DateDue { get; set; }

        public TaskItems TaskItems { get; set; }

        public string DriveLink { get; set; }

        public string Notes { get; set; }
    }
}
