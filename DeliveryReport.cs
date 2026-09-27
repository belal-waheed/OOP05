namespace OOP05
{
    public class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment == null) return;
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            if (shipment == null) return;

            string label = shipment switch
            {
                StandardShipment => "Standard Shipment",
                ExpressShipment => "Express Shipment",
                InternationalShipment => "International Shipment",
                _ => "Shipment"
            };

            Console.WriteLine($"{label} Insurance : {shipment.CalculateInsurance():0.00} EGP");
        }
    }
}
