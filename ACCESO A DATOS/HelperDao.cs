using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPublicarPrecios.ACCESO_A_DATOS
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private string CadenaConexion;
        private HelperDao()
        {
            CadenaConexion = @"Data Source=172.16.1.253;Initial Catalog = dadosprb;user id = totvs; password = totvs*123";
        }
        public static HelperDao Instancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public string CadenaConeccion()
        {
            return CadenaConexion;
        }
    }
}
