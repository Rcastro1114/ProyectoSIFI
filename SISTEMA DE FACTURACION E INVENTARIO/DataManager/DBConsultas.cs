﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT 
            a.idUsuarios,a.Usuario, a.idEmpleados, a.idRoles,
            b.Nombres, b.Apellidos,c.Roles  
            FROM usuarios a, empleados b, roles c
            WHERE a.Usuario='" + pUsuario + @"' 
            AND a.Clave=SHA1(MD5('" + pClave + @"')) 
            AND a.idEmpleados=b.idEmpleados 
            AND a.idRoles=c.idRoles;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ROLES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IDRol, Rol FROM roles;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}