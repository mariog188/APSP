using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace APSP.SuperHeroesXML.Interfaces
{
    [ServiceContract]
    interface IHeroesXML
    {
        [OperationContract]
        string ObtenerHeroes(string rutaDatos);


    }
}
