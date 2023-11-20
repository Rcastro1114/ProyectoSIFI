using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager;



namespace General.CLS
{
    class detalleventas 
    {
        String _idDetalleVentas;
        String _idVentas;
        String _idProductos;
        String _Cantidad;
        float _PrecioVenta;
        float _VentasNoSujetas;
        float _VentasExentas;
        float _SubTotal;
        

        public string idDetalleVentas { get => _idDetalleVentas; set => _idDetalleVentas = value; }
        public string idVentas { get => _idVentas; set => _idVentas = value; }
        public string idProductos { get => _idProductos; set => _idProductos = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public float PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public float VentasNoSujetas { get => _VentasNoSujetas; set => _VentasNoSujetas = value; }
        public float VentasExentas { get => _VentasExentas; set => _VentasExentas = value; }
        public float SubTotal { get => _SubTotal; set => _SubTotal = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO detalleventas(idVentas,idProductos,Cantidad,PrecioVenta,VentasNoSujetas,VentasExentas,SubTotal) 
                            VALUES('" + _idVentas+"','" + _idProductos + "','" + _Cantidad + "','" + _PrecioVenta + "','" + _VentasNoSujetas + "','" + _VentasExentas + "','"+ _SubTotal +"');";
               
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean ProcesarDetalleVenta(String _DetalleVentaUltimo)
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"UPDATE ventas AS v
                INNER JOIN detalleventas AS dv ON dv.idVentas = v.idVentas
                INNER JOIN productos AS p ON p.idProductos = dv.idProductos
                where dv.idDetalleVentas = " + _DetalleVentaUltimo + @"
                and v.idVentas = dv.idVentas
                and p.idProductos = dv.idProductos;";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);

                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Eliminar(String _BUSCARIDVENTA)
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"delete from detalleventas where idVentas = " + _BUSCARIDVENTA + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);

                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

    }
}
