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
            String Sentencia = @"SELECT idRoles, Roles FROM roles;";
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

        public static DataTable PRODUCTOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idProductos,Productos,PrecioUnitario,Marca,Stock FROM productos;";
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

        public static DataTable KARDEXPRODUCTOS()
        {
            DataTable Resultado = new DataTable();
                String Sentencia = @"select m.idMovimientos,m.Fecha,m.idProductos,p.Productos,
                                    m.TipodeMovimiento,m.Saldo
                                    from movimientos m
                                    INNER JOIN productos p
                                    on m.idProductos = p.idProductos;";
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

        public static DataTable BUSCARPRODUCTOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select idProductos,Productos, PrecioUnitario, Stock from productos;";
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

        public static DataTable DEPARTAMENTOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idDepartamentos, Departamentos FROM departamentos;";
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

        public static DataTable MUNICIPIOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idMunicipios, municipios, idDepartamentos FROM municipios;";
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

        public static DataTable DIRECCIONES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idDirecciones, Residencia, Canton, Cacerio,idMunicipios FROM direcciones;";
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

        public static DataTable MOSTRAR_DIRECCIONES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select d.idDirecciones, d.Residencia, d.Canton, d.Cacerio,
                                m.municipios, dep.departamentos 
                                from direcciones d
                                INNER JOIN municipios m
                                on d.idMunicipios=m.idMunicipios
                                INNER JOIN departamentos dep
                                on m.idDepartamentos=dep.idDepartamentos;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            } catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idEmpleados, Nombres, Apellidos,DUI,Telefono,Correo,idDirecciones FROM empleados;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable MOSTRAR_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select em.idEmpleados, em.Nombres, em.Apellidos, em.DUI,
                                em.Telefono, em.Correo, em.idDirecciones,
                                d.Residencia, d.Cacerio, d.Canton, m.municipios
                                from empleados em
                                INNER JOIN direcciones d
                                on em.idDirecciones=d.idDirecciones
                                INNER JOIN municipios m
                                on d.idMunicipios=m.idMunicipios
                                INNER JOIN departamentos dep
                                on m.idDepartamentos=dep.idDepartamentos;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }catch(Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT idClientes, Nombres, Apellidos,Telefono,Correo,idDirecciones FROM clientes;";
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

        public static DataTable MOSTRAR_CLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select em.idClientes, em.Nombres, em.Apellidos,
                                em.Telefono, em.Correo, em.idDirecciones,
                                d.Residencia, d.Cacerio, d.Canton, m.municipios
                                from Clientes em
                                INNER JOIN direcciones d
                                on em.idDirecciones=d.idDirecciones
                                INNER JOIN municipios m
                                on d.idMunicipios=m.idMunicipios
                                INNER JOIN departamentos dep
                                on m.idDepartamentos=dep.idDepartamentos;";
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
        public static DataTable FORMASDEPAGO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM formasdepagos;";
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

        public static DataTable BuscarUltimoDetalleVenta()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select idDetalleVentas from detalleventas  order by idDetalleVentas desc limit 1;";
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

        public static DataTable OBTENERULTIMAVENTA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select idVentas from ventas order by idVentas desc limit 1";
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

        public static DataTable OBTENERULRIMACOMPRA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select idCompras from compras order by idCompras desc limit 1";
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
