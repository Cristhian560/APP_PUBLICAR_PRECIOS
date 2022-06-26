using AppPublicarPrecios.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPublicarPrecios.ACCESO_A_DATOS.IMPLEMENTACIONES
{
    internal class CodigosDAO
    {
        private string CadenaConexion;
        private SqlConnection cnn;
        public CodigosDAO()
        {
            CadenaConexion = HelperDao.Instancia().CadenaConeccion();
            cnn = new SqlConnection(CadenaConexion);
        }
        public bool PublicarProducto(List<CodigoProducto> lista_codigo_producto)
        {
            bool flag = true;
            cnn.Open();
            try
            {
                foreach (CodigoProducto codigoProducto in lista_codigo_producto)
                {
                    SqlCommand cmd = new SqlCommand("SP_PUBLICAR_PRODUCTOS", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codigo", codigoProducto.Codigo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            return flag;
        }
        public bool PublicarProveedor(List<CodigoProveedor> lista_codigo_proveedor)
        {
            bool flag = true;
            cnn.Open();
            try
            {
                foreach (CodigoProveedor codigoProveedor in lista_codigo_proveedor)
                {
                    SqlCommand cmd = new SqlCommand("SP_PUBLICAR_PROVEEDORES", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codigo", codigoProveedor.Codigo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            return flag;
        }
    }
}
