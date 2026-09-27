namespace OOP05
{
    public class Driver
    {
        public string Name { get; set; }

        public Driver(string? name)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
        }
    }
}
