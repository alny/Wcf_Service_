using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Domain;

namespace WcfService_v1 {
    public class BeverageService : IBeverageService {

        private BeverageController beverageController = new BeverageController();
        public List<Beverage> GetBeverages() {
            return beverageController.GetAll();
        }
    }
}
