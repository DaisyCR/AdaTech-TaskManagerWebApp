using TaskManager.Models.Enums;

namespace TaskManager.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Status? Status { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        //public dynamic? Responsible { get; set; } //TODO create user

        public Assignment()
        {
            
        }
    }
}
