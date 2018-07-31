using System;
using System.Collections.Generic;

namespace Task2___Present
{
    public class Present
    {
        public List<Sweet> sweets = new List<Sweet>();


        //Adds a sweet to the present
        public void AddSweet (Sweet sweet)
        {
            sweets.Add(sweet);
            Console.WriteLine("The sweet was added to the present!");
        }

        //Removes a sweet from the present
        public void RemoveSweets (string name)
        {
            List<Sweet> itemsToRemove = new List<Sweet>();
            foreach (Sweet sweet in sweets)
            {
                if (sweet.name == name)
                {
                    itemsToRemove.Add(sweet);
                }
            }
            if (itemsToRemove.Count != 0)
            {
                foreach (Sweet sweet in itemsToRemove)
                {
                    sweets.Remove(sweet);
                    Console.WriteLine("The sweets were removed!");
                }
            }
            else
            {
                Console.WriteLine("No items to remove!");
            }
        }

        //Shows what sweets are contained in the present
        public void ShowContents()
        {
            if (sweets == null)
            {
                Console.WriteLine("There are no sweets in the present!");
            }
            else
            {
                UserInput input = new UserInput();
                Console.WriteLine("Your present contains the following items: ");
                foreach (Sweet sweet in sweets)
                {
                    Console.WriteLine(sweet.name + " " + Convert.ToString(sweet.sweetWeight) + "g.");
                }
                Console.WriteLine("Total weight: " + PresentWeight() + "g.");
            }
        }

        //Calculates the total weight of the present
        public double PresentWeight()
        {
            UserInput input = new UserInput();
            double presentWeight = 0.0;
            foreach (Sweet sweet in sweets)
            {
                presentWeight += input.presentWeight;
            }
            return presentWeight;
        }

        //Sorts the sweets in the present by price
        public void SortByPrice()
        {
            PriceSorter price = new PriceSorter();
            sweets.Sort(price);
            foreach (Sweet sweet in sweets)
            {
                Console.WriteLine(sweet.name + " " + sweet.price);
            }
        }

        //Allows to find a sweet/sweets by specifying the weight range
        public void FindByWeight()
        {
            double sweetsWeight;
            Console.WriteLine("Enter min weight: ");
            double minWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter max weight: ");
            double maxWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The following sweets fit into the specified weight range (" + minWeight + " - " + maxWeight + "): ");
            foreach (Sweet sweet in sweets)
            {
                sweetsWeight = sweet.sweetWeight;
                if (sweetsWeight >= minWeight && sweetsWeight <= maxWeight)
                {
                    Console.WriteLine(sweet.name + ", " + sweet.sweetWeight + "g. ");
                }
            }
        }
      
    }
}