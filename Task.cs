using Microsoft.AspNetCore.Mvc;

namespace RedisExploration
{
    public class Task : Controller
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateOnly DueDate { get; set; }
    }
}
