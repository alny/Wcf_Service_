using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class BeverageController {

        private DbBeverage dbBeverage = new DbBeverage();
        public List<Beverage> GetAll() {
            return dbBeverage.GetBeverages();
        }


    }
}
