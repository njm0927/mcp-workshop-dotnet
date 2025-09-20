namespace MyMonkeyApp
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AsciiArt { get; set; }

        public Monkey(string name, string description, string asciiArt)
        {
            Name = name;
            Description = description;
            AsciiArt = asciiArt;
        }
    }
}
