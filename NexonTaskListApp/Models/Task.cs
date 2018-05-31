using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexonTaskListApp.Models
{
    public class Task
    {
        public string Name { get; set; }
        public string Requester { get; set; }
        public string Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<Task> Subtasks { get; set; }
    }
}