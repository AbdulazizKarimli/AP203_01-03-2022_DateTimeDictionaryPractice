using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePractice
{
    internal class User
    {
        List<Status> _statuses;

        public string Username { get; set; }

        public User()
        {
            _statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {
            _statuses.Add(status);
        }
        public string GetStatusByTitle(string title)
        {
            foreach (var status in _statuses)
            {
                if (status.Title == title)
                    return $"Title: {status.Title} - Content: {status.Content} shared {(DateTime.Now - status.SharedDate).Seconds} seconds ago";
            }
            throw new NotFoundException("bele bir status yoxdur");
        }
    }
}
