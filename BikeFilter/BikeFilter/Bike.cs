using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    public abstract class Bike

    {
        public  int Id { get; set; }
        public  string Brand { get; set; }
        public  string Model { get; set; }
        public  int Rating { get; set; }
        public  int Price { get; set; }
        public  condition Condition { get; set; }
        public  int Year { get; set; }

        public abstract string BikeType { get; set; }

        public Bike(int id, string brand, string model, int rating, int price, condition condition, int year)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Rating = rating;
            this.Price = price;
            this.Condition = condition;
            this.Year = year;
        }
    }

    public enum condition
    {
        good,
        bad,
        perfect
    }
}
