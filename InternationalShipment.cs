namespace OOP05
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry = "Unknown";
        private decimal customsFee;

        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m) + CustomsFee;

        public InternationalShipment(string trackingCode)
            : base(trackingCode)
        {
            DestinationCountry = "Unknown";
            CustomsFee = 0m;
            TrackingStatus = "Delivered";
            Console.WriteLine("International Shipment Created");
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = string.IsNullOrWhiteSpace(destinationCountry) ? "Unknown" : destinationCountry;
            CustomsFee = customsFee >= 0 ? customsFee : 0m;
            TrackingStatus = "Delivered";
            Console.WriteLine("International Shipment Created");
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("--- Customs Report ---");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} has been Delivered.";
        public decimal CalculateInsurance() => EstimatedCost * 0.12m;
    }
}
