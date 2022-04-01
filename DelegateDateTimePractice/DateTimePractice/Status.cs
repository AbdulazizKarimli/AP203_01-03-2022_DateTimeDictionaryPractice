using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePractice
{
    internal class Status
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }

        public Status(string title, string content)
        {
            Title = title;
            Content = content;
            SharedDate = DateTime.Now;
        }
    }
}
