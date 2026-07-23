using Hotels.Domain.Enums;

namespace Hotels.Domain.Entities
{
    public class Destination
    {
        public long Id { get; private set; }

        public string Name { get; private set; }

        public DestinationType Type { get; private set; }

        public long? ParentId { get; private set; }

        public Destination? Parent { get; private set; }

        public Destination(string name, DestinationType type, long? parentId)
        {
            Name = name;
            Type = type;
            ParentId = parentId;
        }
    }
}
