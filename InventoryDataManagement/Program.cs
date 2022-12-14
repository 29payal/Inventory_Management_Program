using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\DELL\\Desktop\\RFP\\InventoryDataManagement\\InventoryData.json ";

            FetchForJsonRiceData fetchForJsonRiceData = new FetchForJsonRiceData();

            Rice data = fetchForJsonRiceData.Read(filePath);

            // Console.WriteLine(data.typeOfRice.name);
            //  Console.WriteLine(data.typeOfRice.weight);
            //  Console.WriteLine(data.typeOfRice.price);
            Console.WriteLine("Data for Rice :-");

            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                Console.WriteLine("____________________________________");
                Console.WriteLine("Calculate the weight and price for Rice : ");
                int value = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine(value);
                Console.WriteLine("_______________________________________");


            }

            Console.WriteLine("Data for Pulses :-");

            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine(data.typeOfPulses[i].name);
                Console.WriteLine(data.typeOfPulses[i].weight);
                Console.WriteLine(data.typeOfPulses[i].price);
                Console.WriteLine("____________________________________");
                Console.WriteLine("Calculate the weight and price for Pulses :");
                int value = data.typeOfPulses[i].weight * data.typeOfPulses[i].price;
                Console.WriteLine(value);
                Console.WriteLine("_______________________________");
            }

            Console.WriteLine("Data for Wheat :-");

            for (int i = 0; i < data.typeOfWheat.Count; i++)
            {
                Console.WriteLine(data.typeOfWheat[i].name);
                Console.WriteLine(data.typeOfWheat[i].weight);
                Console.WriteLine(data.typeOfWheat[i].price);
                Console.WriteLine("____________________________________");
                Console.WriteLine("Calculate the weight and price for Wheat :");
                int value = data.typeOfWheat[i].weight * data.typeOfWheat[i].price;
                Console.WriteLine(value);
                Console.WriteLine("____________________________________");
            }
            Console.ReadLine();
        }
    }
}