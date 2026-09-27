namespace OOP05
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m) + ExtraFee;

        public ExpressShipment(string trackingCode)
            : base(trackingCode)
        {
            ExtraFee = 0m;
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee >= 0 ? extraFee : 0m;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} is Out for Delivery.";
        public decimal CalculateInsurance() => EstimatedCost * 0.08m;
    }
}
