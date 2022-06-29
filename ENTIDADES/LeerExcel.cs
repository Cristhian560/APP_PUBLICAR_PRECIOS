using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPublicarPrecios.ENTIDADES
{
    internal class LeerExcel
    {
        private int ultima_fila;
        private SLDocument sl;
        public List<CodigoProducto> lista_codigo_productos;
        public List<CodigoProveedor> lista_codigos_proveedores;
        public LeerExcel(string ubicacion)
        {
            try
            {
                sl = new SLDocument(ubicacion);
                SLWorksheetStatistics propiedades = sl.GetWorksheetStatistics();
                ultima_fila = propiedades.EndRowIndex;
            }
            catch (IOException)
            {
                MessageBox.Show("POR FAVOR CERRAR EL EXCEL");
            }
        }
        public List<CodigoProducto> ListaCodigoProducto()
        { 
            lista_codigo_productos = new List<CodigoProducto>();
            for (int i = 2; i <= ultima_fila; i++)
            {
                string codigo = sl.GetCellValueAsString("A" + i);
                CodigoProducto codigoProducto = new CodigoProducto();
                if (codigo!="" && ComprobarCodigoProducto(codigo))
                {
                    codigoProducto.Codigo = codigo;
                    lista_codigo_productos.Add(codigoProducto);
                }
            }
            return lista_codigo_productos;
        }
        public bool ComprobarCodigoProducto(string codigo)
        {
            try
            {
                int x = Convert.ToInt32(codigo);
                if (codigo.Length == 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("LOS CODIGOS NO DEBEN CONTENER CARACTERES","ERROR");
                return false;
            }
        }
        public List<CodigoProveedor> ListaCodigoProveedor()
        {
            lista_codigos_proveedores = new List<CodigoProveedor>();
            for (int i = 2; i <= ultima_fila; i++)
            {
                string codigo = FormatearCodigoProveedor(sl.GetCellValueAsString("B" + i));
                CodigoProveedor OCodigoProveedor = new CodigoProveedor();
                
                if (codigo!="")
                {
                    OCodigoProveedor.Codigo = codigo;
                    lista_codigos_proveedores.Add(OCodigoProveedor);
                }
            }
            return lista_codigos_proveedores;
        }
        public string FormatearCodigoProveedor(string codigo)
        {    
            string cod = "";
            try
            { 
                if (codigo != "")
                {
                    int x = Convert.ToInt32(codigo);
                    if (codigo.Length < 6 )
                    {
                        if (codigo.Length == 1)
                        {
                            cod = "00000" + codigo;
                        }
                        else if (codigo.Length == 2)
                        {
                            cod = "0000" + codigo;
                        }
                        else if (codigo.Length == 3)
                        {
                            cod = "000" + codigo;
                        }
                        else if (codigo.Length == 4)
                        {
                            cod = "00" + codigo;
                        }
                        else if (codigo.Length == 5)
                        {
                            cod = "0" + codigo;
                        }
                        else
                        {
                            cod = codigo;
                        }
                        return cod;
                    }
                    else if (codigo.Length == 6)
                    {
                        return codigo;
                    }
                    else
                    {
                        MessageBox.Show("HAY CODIGOS DE PROVEEDORES QUE TIENEN MAS DE 6 DIGITOS REVISAR! \n" +
                            "LOS CODIGOS DE PROVEEDOR CON MAS DE 6 DIGITOS NO SE PUBLICARAN","ERROR");
                    }
                }
            }
            catch
            {
                MessageBox.Show("LAS COLUMNAS NO DEBEN CONTENER CARACTERES \n" +
                    "LOS CODIGOS DE PROVEEDOR QUE CONTIENEN CARACTERES NO SE PUBLICARAN ","ERROR");
            }
            return cod;
        }
    }
}
