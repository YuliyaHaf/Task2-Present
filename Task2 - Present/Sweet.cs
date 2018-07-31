
namespace Task2___Present
{
    public class Sweet
    {       
        public string category { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double sweetWeight { get; set; } //gramms

        public Sweet() { }
        public Sweet(string Category, string Name, double Price, double Weight)
        {
            this.category = category;
            this.name = name;
            this.price = price;
            this.sweetWeight = sweetWeight;
        }
    }
}
