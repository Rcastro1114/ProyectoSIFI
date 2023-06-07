﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager
{
    public class DBOperacion:DBConexion
    {
        public int NoFactura()
        {
            int NoFactura = 0;
            MySqlCommand Comando = new MySqlCommand();
            if(base.Conectar())
            {
              
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 ventas");
                    MySqlCommand comando = new MySqlCommand(query.ToString());
                    comando.CommandType = CommandType.Text;

                    NoFactura = Convert.ToInt32(comando.ExecuteScalar());
                }catch (Exception)
                {
                    NoFactura = 0;
                }
            }
            return NoFactura;
        }

        public Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            MySqlCommand Comando = new MySqlCommand();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pSentencia;
                try
                {
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    FilasAfectadas = -1;
                }
                base.Desconectar();
            }
            return FilasAfectadas;
        }

        public DataTable Consultar(String pConsulta)
        {
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            MySqlCommand Comando = new MySqlCommand();
            DataTable Resultado = new DataTable();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pConsulta;
                Adaptador.SelectCommand = Comando;
                try
                {
                    Adaptador.Fill(Resultado);
                }
                catch (Exception)
                {
                    Resultado = new DataTable();
                }
                base.Desconectar();
            }
            return Resultado;
        }
    }
}
