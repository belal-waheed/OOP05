namespace OOP05
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        public Driver? Driver { get; set; }
        private Shipment?[] shipments;
        private int count;

        public DeliveryCenter() : this("Unknown", null)
        {
        }

        public DeliveryCenter(string? centerName) : this(centerName, null)
        {
        }

        public DeliveryCenter(string? centerName, Driver? driver)
        {
            CenterName = string.IsNullOrWhiteSpace(centerName) ? "Unknown" : centerName;
            Driver = driver;
            shipments = new Shipment?[20];
            count = 0;
        }

        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipments[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                {
                    return null;
                }

                for (int i = 0; i < count; i++)
                {
                    if (shipments[i]?.TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment? shipment)
        {
            if (shipment == null || count >= shipments.Length)
            {
                return false;
            }

            shipments[count++] = shipment;
            return true;
        }

        public bool RemoveShipment(string? trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode) || count == 0)
            {
                return false;
            }

            int targetIndex = -1;
            for (int i = 0; i < count; i++)
            {
                if (shipments[i]?.TrackingCode == trackingCode)
                {
                    targetIndex = i;
                    break;
                }
            }

            if (targetIndex == -1)
            {
                return false;
            }

            for (int i = targetIndex; i < count - 1; i++)
            {
                shipments[i] = shipments[i + 1];
            }

            shipments[count - 1] = null;
            count--;
            return true;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine(CenterName);
            Console.WriteLine("==========================================");
            if (Driver != null)
            {
                Console.WriteLine($"\nDriver : {Driver.Name}\n");
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("------------------------------------------\n");
                shipments[i]?.PrintShipment();
                Console.WriteLine();
            }
            Console.WriteLine("==========================================");
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine("Tracking Status");
            for (int i = 0; i < count; i++)
            {
                if (shipments[i] is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
            Console.WriteLine("==========================================");
        }
    }
}
