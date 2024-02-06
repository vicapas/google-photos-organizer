namespace GooglePhotosOrganizer.Models
{
    public class CopyFile
    {
        public string? Path { get; set; }
        public string? FileName { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Year { get; set; }

        public CopyFile(string? path, string? fileName, DateTime? dateTime)
        {
            Path = path;
            FileName = fileName;
            DateTime = dateTime;
            if (dateTime.HasValue) Year = dateTime.Value.Year;
        }
    }
}