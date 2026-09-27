namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryUtilities.PrintHeader("Smart Delivery Management System");
            Console.WriteLine();

            Shipment.GetTotalShipmentsCreated();
            Console.WriteLine();

            #region Shipment Creation
            DeliveryUtilities.PrintHeader("Creating Shipments...");
            Console.WriteLine();

            StandardShipment std = new StandardShipment("PKG101", "Gaming Monitor", 4m, 70m, new DeliveryAddress("Alexandria", "Corniche St", 12));
            ExpressShipment exp = new ExpressShipment("PKG102", "Headphones", 2m, 50m, new DeliveryAddress("Mansoura", "Gomhouria St", 4), 25m);
            InternationalShipment intl = new InternationalShipment("PKG103", "Camera Kit", 7m, 110m, new DeliveryAddress("Dubai", "Sheikh Zayed Rd", 88), "UAE", 90m);

            Console.WriteLine();
            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            Console.WriteLine();
            #endregion

            #region Object Copying (Reference Assignment)
            DeliveryUtilities.PrintHeader("Object Copying");
            Console.WriteLine();

            Shipment assigned = std;
            Console.WriteLine($"Original Shipment  : {std.TrackingCode}");
            Console.WriteLine($"Assigned Shipment  : {assigned.TrackingCode}");
            Console.WriteLine();
            Console.WriteLine($"Same Object : {ReferenceEquals(std, assigned)}");
            Console.WriteLine();
            #endregion

            #region Shallow Copy
            DeliveryUtilities.PrintSystemTitle("Shallow Copy");
            Console.WriteLine();

            Shipment shallow = std.ShallowCopy();
            Console.WriteLine($"Original Shipment Address : {std.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallow.Destination.City}");
            Console.WriteLine();

            Console.WriteLine("Changing copied shipment address...");
            shallow.Destination.City = "Mansoura";
            Console.WriteLine();

            Console.WriteLine($"Original Shipment Address : {std.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallow.Destination.City}");
            Console.WriteLine();

            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(std.Destination, shallow.Destination)}");
            Console.WriteLine();
            #endregion

            #region Deep Copy
            std.Destination.City = "Alexandria";
            DeliveryUtilities.PrintSystemTitle("Deep Copy");
            Console.WriteLine();

            Shipment deep = std.DeepCopy();
            Console.WriteLine($"Original Shipment Address : {std.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deep.Destination.City}");
            Console.WriteLine();

            Console.WriteLine("Changing copied shipment address...");
            deep.Destination.City = "Mansoura";
            Console.WriteLine();

            Console.WriteLine($"Original Shipment Address : {std.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deep.Destination.City}");
            Console.WriteLine();

            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(std.Destination, deep.Destination)}");
            Console.WriteLine();
            #endregion

            #region Extension Methods
            DeliveryUtilities.PrintHeader("Extension Methods");
            Console.WriteLine();

            Console.WriteLine(std.GetSummary());
            Console.WriteLine(exp.GetSummary());
            Console.WriteLine(intl.GetSummary());
            Console.WriteLine();

            Console.WriteLine($"{std.TrackingCode} Is Delivered : {std.IsDelivered()}");
            Console.WriteLine($"{intl.TrackingCode} Is Delivered : {intl.IsDelivered()}");
            Console.WriteLine();
            #endregion

            #region Tracking Status
            DeliveryUtilities.PrintHeader("Tracking Status");
            Console.WriteLine();

            std.UpdateTrackingStatus("Out For Delivery");
            Console.WriteLine();
            #endregion

            #region Static Utilities
            DeliveryUtilities.PrintHeader("Static Utilities");
            Console.WriteLine();

            DeliveryUtilities.PrintSystemTitle("Delivery Center");
            Console.WriteLine();

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            Console.WriteLine();
            #endregion

            #region Partial Method
            DeliveryUtilities.PrintHeader("Partial Method");
            Console.WriteLine();

            std.UpdateTrackingStatus("Delivered");
            Console.WriteLine();
            #endregion

            DeliveryUtilities.PrintHeader("Assignment Completed");
        }
    }
}
