namespace Hotels.Domain.ValueObjects
{
    public sealed record Address(string Street, string PostalCode, decimal Latitude, decimal Longitude);
}
