
namespace Task2___Present
{
    public class Chocolate:Sweet
    {
        public Chocolate()
        {
            category = "Chocolate";
            name = base.name;
            price = base.price;
            sweetWeight = base.sweetWeight;
        }
    }
}
