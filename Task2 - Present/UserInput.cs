using System;

namespace Task2___Present
{
    class UserInput
    {
        Present present = new Present();

        //Main menu that provides user with the possibility to create a present, see its contents, sort and search the sweets  
        public void MainMenu ()
        {
            int choice = -1;            
            Console.WriteLine("Create your own present!");

            while (choice != 0)
            {
                Console.WriteLine("Select one of the options below: ");
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Display the present content");
                Console.WriteLine("3. Find a sweet by weight");
                Console.WriteLine("4. Sort sweets by price");
                Console.WriteLine("0. Exit");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("No such option! Please, try again or press 0 to exit!");
                    Console.ReadLine();
                    choice = -1;
                }

                switch (choice)
                {
                    case 1:           
                        CreatePresent();
                        break;

                    case 2:
                        present.ShowContents();
                        break;

                    case 3:
                        present.FindByWeight();
                        break;

                    case 4:
                        present.SortByPrice();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }

            }
            Console.ReadLine();
        }

        // Adds sweets according to the user's input
        public double presentWeight { get; set; }
        public void CreatePresent()
        {
            int menu_choice = -1;
            string noCategory = "No such category!";
            string noSweet = "No such sweets in the chosen category!";

            while (menu_choice != 0)
            {
                Console.WriteLine("Select a sweet category, please:");
                Console.WriteLine("1. Caramel");
                Console.WriteLine("2. Chocolate");
                Console.WriteLine("0. Show the main menu");
                try
                {
                    menu_choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(noCategory);
                    Console.ReadLine();
                    menu_choice = -1;
                }

                switch (menu_choice)
                {
                    case 1:
                        Console.WriteLine("Select a sweet: 1. Dyushes, 2. Barbaris");
                        try
                        {
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    {
                                        Dyushes sweet = new Dyushes();
                                        present.AddSweet(sweet);
                                        presentWeight += sweet.sweetWeight;
                                        break;
                                    }
                                case 2:
                                    {
                                        Barbaris sweet = new Barbaris();
                                        present.AddSweet(sweet);
                                        presentWeight += sweet.sweetWeight;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine(noSweet);
                                        Console.ReadLine();
                                        menu_choice = -1;
                                        break;
                                    }
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(noCategory);
                            Console.ReadLine();
                            menu_choice = -1;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Select a sweet: 1. Alyonka, 2. Minchanka");
                        try
                        {
                            int option2 = Convert.ToInt32(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    {
                                        Alyonka sweet = new Alyonka();
                                        present.AddSweet(sweet);
                                        presentWeight += sweet.sweetWeight;
                                        break;
                                    }
                                case 2:
                                    {
                                        Minchanka sweet = new Minchanka();
                                        present.AddSweet(sweet);
                                        presentWeight += sweet.sweetWeight;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine(noSweet);
                                        Console.ReadLine();
                                        menu_choice = -1;
                                        break;
                                    }
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(noCategory);
                            Console.ReadLine();
                            menu_choice = -1;
                        }
                        break;
                    case 0:
                        menu_choice = 0;
                        break;

                    default:
                        Console.WriteLine(noCategory);
                        break;
                }
            }
        }
    }
}
