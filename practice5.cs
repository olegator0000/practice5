using System;
using System.Collections.Generic;

class Program
{
    enum Cities
    {
        Kyiv = 1,
        Lviv,
        Odessa,
        Paris,
        Marseille,
        Lyon,
        Berlin,
        Munich,
        Hamburg
    }

    static void Main()
    {
        Console.WriteLine("Перелік міст:");
        foreach (var city in Enum.GetValues(typeof(Cities)))
        {
            Console.WriteLine($"{(int)city} - {city}");
        }

        Console.WriteLine("Введіть номери міст, які ви хотіли б відвідати, відокремлюючи номери комами:");
        string input = Console.ReadLine();
        string[] cityNumbers = input.Split(',');

        List<Cities> ukraineCities = new List<Cities> { Cities.Kyiv, Cities.Lviv, Cities.Odessa };
        List<Cities> franceCities = new List<Cities> { Cities.Paris, Cities.Marseille, Cities.Lyon };
        List<Cities> germanyCities = new List<Cities> { Cities.Berlin, Cities.Munich, Cities.Hamburg };
        List<Cities> selectedUkraineCities = new List<Cities>();
        List<Cities> selectedFranceCities = new List<Cities>();
        List<Cities> selectedGermanyCities = new List<Cities>();

        foreach (string number in cityNumbers)
        {
            if (int.TryParse(number.Trim(), out int cityNumber))
            {
                if (Enum.IsDefined(typeof(Cities), cityNumber))
                {
                    Cities selectedCity = (Cities)cityNumber;
                    if (ukraineCities.Contains(selectedCity))
                    {
                        selectedUkraineCities.Add(selectedCity);
                    }
                    else if (franceCities.Contains(selectedCity))
                    {
                        selectedFranceCities.Add(selectedCity);
                    }
                    else if (germanyCities.Contains(selectedCity))
                    {
                        selectedGermanyCities.Add(selectedCity);
                    }
                }
            }
        }

        Console.WriteLine("\nАвтор програми: Прізвище Автора");

        Console.WriteLine("\nВибрані міста в Україні:");
        foreach (var city in selectedUkraineCities)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("\nВибрані міста у Франції:");
        foreach (var city in selectedFranceCities)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("\nВибрані міста в Німеччині:");
        foreach (var city in selectedGermanyCities)
        {
            Console.WriteLine(city);
        }
    }
}
