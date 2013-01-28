using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyHobbie.Service
{
    public class TocarGuitarraService : ITocarGuitarraService
    {
        public void Registrar(string MarcaGuitarra, string TipoGuitarra)
        {
            try
            {

            }
            catch (Exception)
            {
                throw new Exception("No se puede registrar nombre igual de la guitarra");
            }
        }

        public void Listar()
        {
            try
            {

            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al mostrar el listado.");
            }
        }
    }
}
