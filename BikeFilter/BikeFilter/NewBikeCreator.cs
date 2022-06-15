using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    class NewBikeCreator: Creator
    {
        public override Bike CreateBike(int id, string brand, string model, int rating, int price, condition condition, int year)
        {
            return new NewBike(id, brand, model, rating, price, condition, year);
        }
    }
}
