namespace OOP05
{
    public class DeliveryAddress
    {
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int BuildingNumber { get; set; }

        public DeliveryAddress()
        {
            City = string.Empty;
            Street = string.Empty;
            BuildingNumber = 0;
        }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city ?? string.Empty;
            Street = street ?? string.Empty;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{Street} {BuildingNumber}, {City}";
        }

        public override string ToString() => GetFullAddress();
    }
}
