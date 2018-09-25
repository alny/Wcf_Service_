using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class DbBeverage {


        public List<Beverage> GetBeverages() {

            List<Beverage> beverages = new List<Beverage> {
                new Beverage {Id = 1, Name = "Vodka", APB = 37.5 },
                new Beverage {Id = 1, Name = "Tuborg", APB = 4.6 }
            };

            return beverages;

        }


    }
}
