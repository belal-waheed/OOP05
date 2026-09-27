namespace OOP05
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string type = "Shipment";

            if (shipment is StandardShipment)
            {
                type = "Standard";
            }
            else if (shipment is ExpressShipment)
            {
                type = "Express";
            }
            else if (shipment is InternationalShipment)
            {
                type = "International";
            }

            return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}
