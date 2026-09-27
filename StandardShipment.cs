namespace OOP05
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
            TrackingStatus = "In Transit";
            Console.WriteLine("Standard Shipment Created");
        }

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            TrackingStatus = "In Transit";
            Console.WriteLine("Standard Shipment Created");
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m);

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} is Ready.";
        public decimal CalculateInsurance() => EstimatedCost * 0.05m;
    }
}
