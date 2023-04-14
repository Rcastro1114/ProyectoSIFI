﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public class Session
    {
        //Atributos
        static Session _Instancia = null;
        static readonly Object _codelock = new Object();

        String _Usuario;
        String _idUsuarios;
        String _Roles;
        String _idRoles;



        //Propiedades
        public static Session Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    lock (_codelock)
                    {
                        if (_Instancia == null)
                        {
                            _Instancia = new Session();
                        }
                    }
                }
                return _Instancia;
            }
        }

        public string Usuario { get => _Usuario; }
        public string IDUsuario { get => _idUsuarios; }
        public string Rol { get => _Roles; }
        public string IDRol { get => _idRoles; }


        //Metodos
        private Session()
        {}
        public Boolean IniciarSesion(String pUsuario, String pClave)
        {
            Boolean result = false;
            DataTable Resultado = new DataTable();
            try
            {
                Resultado = DataManager.DBConsultas.VALIDAR_USUARIO(pUsuario, pClave);
                if (Resultado.Rows.Count == 1)
                {
                    _idUsuarios = Resultado.Rows[0]["idUsuarios"].ToString();
                    _Usuario = Resultado.Rows[0]["Usuario"].ToString();
                    _idRoles = Resultado.Rows[0]["idRoles"].ToString();
                    _Roles = Resultado.Rows[0]["Roles"].ToString();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
