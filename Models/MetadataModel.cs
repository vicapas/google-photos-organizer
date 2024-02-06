namespace GooglePhotosOrganizer.Models
{
    public class MetadataModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public int imageViews { get; set; }
        public MetadataTimeModel creationTime { get; set; }
        public MetadataTimeModel photoTakenTime { get; set; }
        public GeodataModel geoData { get; set; }
        public GeodataModel geoDataExif { get; set; }
        public string? url { get; set; }
    }
}