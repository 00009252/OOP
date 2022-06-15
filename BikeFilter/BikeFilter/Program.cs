using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeList = BikesList.getBikesList;
            bikeList.PopulateWithBikes();
            bikeList.ShowAllBikes();
            bikeList.SearchAssistantShow();
        }
    }
}
