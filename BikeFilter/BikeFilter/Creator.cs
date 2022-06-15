using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    public abstract class Creator
    {
        public abstract Bike CreateBike(int id, string brand, string model, int rating, int price, condition condition, int year);

        public Bike GetBike(int id, string brand, string model, int rating, int price, condition condition, int year) {
            var BikeToReturn = CreateBike(id, brand, model, rating, price, condition, year);
            return BikeToReturn;
        }
    }
}
