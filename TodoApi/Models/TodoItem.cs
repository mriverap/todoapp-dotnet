using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Group { get; set; }
        public DateTime DueDate { get; set; }
        public string Notes { get; set; }
    }
}