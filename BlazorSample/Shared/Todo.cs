using System.ComponentModel.DataAnnotations;

namespace BlazorSample.Shared
{
    public enum TodoStatus
    {
        Ready, InProgress, Done
    }

    public class Todo
    {
        [Required]
        public string Title { get; set; }

        public TodoStatus Status { get; set; } = TodoStatus.Ready;
    }
}
