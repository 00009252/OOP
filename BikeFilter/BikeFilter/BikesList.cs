using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    public class BikesList
    {
        private static BikesList bikesListInstance = null;
        private List<Bike> listOfBikes = null;
        private string Brand { get; set; }
        private string Model { get; set; }
        private int Price { get; set; }
        private string NewOrOld { get; set; }

        private BikesList() { }
        public static BikesList getBikesList
        {
            get
            {
                if (bikesListInstance == null)
                    bikesListInstance = new BikesList();
                return bikesListInstance;
            }
        }

        public void SetSearchProperties(string brand, string Model, int Price)
        {
            this.Brand = brand;
            this.Model = Model;
            this.Price = Price;
        }

        public List<Bike> searchBikes()
        {
            var filteredBikes = this.listOfBikes.Where(item =>
            {
                if (this.Brand.Length != 0)
                {
                    if (item.Brand.ToLower() == this.Brand.ToLower()) return true;
                    else return false;
                }
                else
                {
                    return true;
                }
            }).Where(item =>
            {
                if (this.Model.Length != 0)
                {
                    if (item.Model.ToLower() == this.Model.ToLower()) return true;
                    else return false;
                }
                else
                {
                    return true;
                }
            }).Where(item =>
            {
                if (item.Price <= this.Price)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).Where(item =>
            {
                if (item.BikeType.ToLower() == this.NewOrOld.ToLower())
                {
                    return true;
                } else
                {
                    return false;
                }
            }).ToList();
            return filteredBikes;
        }


        public void ShowAllBikes()
        {
            Console.WriteLine("Here is a list of available bikes:");
            Console.WriteLine("ID, Brand, model, rating, price, condition, year, New/Used");
            listOfBikes.ForEach(item =>
            {
                Console.WriteLine($"{item.Id}, {item.Brand}, {item.Model}, {item.Rating}, {item.Price}, {item.Condition}, {item.Year}, {item.BikeType}");
            });
        }

        public void SearchAssistantShow()
        {
            Console.WriteLine("Type the brand, model and price of bike to search: ");
            Console.WriteLine("Brand: ");
            var brand = Console.ReadLine();
            Console.WriteLine("Model: ");
            var model = Console.ReadLine();
            Console.WriteLine("Price: ");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine("New or Old (input is 'new' or 'old'): ");
            var newOrOld = Console.ReadLine();
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
            this.NewOrOld = newOrOld;
            Console.WriteLine("Enter to search...");
            Console.ReadLine();
            showFilteredList();
        }

        public void showFilteredList()
        {
            Console.WriteLine("Here is your search results:");
            searchBikes().ForEach(item =>
            {
                Console.WriteLine($"{item.Id}, {item.Brand}, {item.Model}, {item.Rating}, {item.Price}, {item.Condition}, {item.Year}, {item.BikeType}");
            });
            Console.ReadLine();
        }



        public void PopulateWithBikes()
        {
            listOfBikes = new List<Bike>();
            var NewBikeCreator = new NewBikeCreator();
            var UsedBikeCreator = new UsedBikeCreator();
            var b1 = NewBikeCreator.CreateBike(
                1,
                "3T Bikes",
                "3TTT",
                3,
                100,
                condition.perfect,
                2012
                );
            var b2 = NewBikeCreator.CreateBike(
                2,
                "Alchemy Bicycles",
                "AlchaBikeX3",
                5,
                200,
                condition.perfect,
                2015
                );
            var b3 = UsedBikeCreator.CreateBike(
                3,
                "All-City Cycles",
                "BM33X",
                5,
                300,
                condition.perfect,
                2013
                );
            var b4 = UsedBikeCreator.CreateBike(
                4,
                "Bianchi Bicycles",
                "Roller3T",
                5,
                300,
                condition.perfect,
                2011
                );
            listOfBikes.Add(b1);
            listOfBikes.Add(b2);
            listOfBikes.Add(b3);
            listOfBikes.Add(b4);
        }

    }
}
