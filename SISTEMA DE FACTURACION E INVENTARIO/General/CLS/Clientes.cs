using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Clientes
    {
        int _idClientes;
        String _Nombres;
        String _Apellidos;
        String _Telefono;
        String _Correo;
        int _idDirecciones;

        public int IdClientes { get => _idClientes; set => _idClientes = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int IdDirecciones { get => _idDirecciones; set => _idDirecciones = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO clientes(Nombres,Apellidos,Telefono,Correo,idDirecciones)
                            VALUES('"+_Nombres+"','"+_Apellidos+"','"+_Telefono+"','"+_Correo+"','"+_idDirecciones+"');";
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
