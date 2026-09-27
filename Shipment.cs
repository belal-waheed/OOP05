namespace OOP05
{
    public abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode => trackingCode;

        public string Description
        {
            get => description;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get => weight;
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public abstract decimal EstimatedCost { get; }

        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1m, 50m, new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "Unknown" : trackingCode;
            this.description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
            this.weight = weight > 0 ? weight : 1m;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50m;
            Destination = destination ?? new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        public abstract void PrintShipment();

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight >= 0)
            {
                weight = newWeight + packingWeight;
            }
        }
    }
}
