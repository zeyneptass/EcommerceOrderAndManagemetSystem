using Core.Entities;

namespace Entities.Concrete
{
    public class Message : IEntity
    {
        public int MessageID { get; set; }
        public string QueueName { get; set; }
        public string Payload { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
