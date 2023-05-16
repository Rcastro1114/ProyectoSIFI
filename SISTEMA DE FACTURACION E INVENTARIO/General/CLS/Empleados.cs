using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Empleados
    {
        int _idEmpleados;
        String _Nombres;
        String _Apellidos;
        String _DUI;
        String _Telefono;
        String _Correo;
        String _idDirecciones;

        public int idEmpleados { get => _idEmpleados; set => _idEmpleados = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string DUI { get => _DUI; set => _DUI = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string idDirecciones { get => _idDirecciones; set => _idDirecciones = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO empleados(Nombres,Apellidos,DUI,Telefono,Correo,idDirecciones) VALUES("+_Nombres+","+_Apellidos+","+_DUI+","+_Telefono+","+_Correo+","+_idDirecciones+"); ";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if(FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }catch (Exception)
            {
                Resultado = false;
            }

            return Resultado;
        }
    }
}
