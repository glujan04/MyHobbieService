using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyHobbie.Service
{
    [ServiceContract]
    public interface ITocarGuitarraService
    {
        [OperationContract]
        void Registrar(string MarcaGuitarra, string TipoGuitarra);

        [OperationContract]
        void Listar();
    }
}
