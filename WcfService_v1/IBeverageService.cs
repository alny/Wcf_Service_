using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService_v1 {

    [ServiceContract]
    public interface IBeverageService {

        [OperationContract]
        List<Beverage> GetBeverages();

    }
}
