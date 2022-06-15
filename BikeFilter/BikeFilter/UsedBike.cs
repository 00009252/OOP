using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    class UsedBike: Bike
    {
        public UsedBike(int id, string brand, string model, int rating, int price, condition condition, int year) : base(id, brand, model, rating, price, condition, year)
        {
            this.BikeType = "NewBike";
        }
        public override string BikeType { get { return "Old"; } set { } }


    }
}
