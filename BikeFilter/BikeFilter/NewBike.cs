using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    class NewBike : Bike
    {
        public NewBike(int id, string brand, string model, int rating, int price, condition condition, int year) : base(id, brand, model, rating, price, condition, year)
        {
            this.BikeType = "NewBike";
        }
        public override string BikeType { get { return "New"; } set { } }
    }
}
