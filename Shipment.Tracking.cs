namespace OOP05
{
    public abstract partial class Shipment
    {
        public string TrackingStatus { get; set; } = "In Transit";

        partial void OnTrackingStatusChanged(string newStatus);

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
    }
}
