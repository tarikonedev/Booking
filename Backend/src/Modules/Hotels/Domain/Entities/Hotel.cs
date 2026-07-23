using Hotels.Domain.Enums;
using Hotels.Domain.ValueObjects;

namespace Hotels.Domain.Entities
{
    public class Hotel
    {
        public long Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public long DestinationId { get; private set; }

        public long CountyId {  get; private set; }

        public decimal Rating { get; private set; }

        public Address Address { get; private set; }

        public HotelStatus Status { get; private set; }

        public Destination? Destination { get; private set; }

        public Hotel(string name, string description, long destinationId, long countyId, Address address)
        {
            Name = name;
            Description = description;
            DestinationId = destinationId;
            CountyId = countyId;
            Rating = 0;
            Address = address;
            Status = HotelStatus.Active;
        }
    }
}
