﻿using proyecto_final_club_deportivo.Datos;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Logica
{
    internal class UsuarioController
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        
        public DataTable login(string username, string password)
        {
            string pass = getSHA256(password);
            return this.usuarioRepository.loginUsuario(username, pass);
        }

        public DataTable listarUsuarios()
        {
            return usuarioRepository.listarUsuarios();
        }

        public DataTable buscarUsuarioPorId(int id)
        {
            return usuarioRepository.buscarUsuarioPorId(id);
        }

        public DataTable buscarUsuarioPorUsername(string username)
        {
            return usuarioRepository.buscarUsuarioPorUsername(username);
        }

        public DataTable buscarRol(string nombre)
        {
            return usuarioRepository.buscarRol(nombre);
        }

        public string crearUsuario(Usuario usuario, int idRol)
        {
            return usuarioRepository.crearUsuario(usuario, idRol);
        }

        public string editarUsuario(Usuario usuario, int idRol)
        {
            return usuarioRepository.editarUsuario(usuario, idRol);
        }

        public string eliminarUsuario(int id)
        {
            return usuarioRepository.eliminarUsuario(id);
        }

        // Encripta la contraseña con un algoritmo SHA256
        public static string getSHA256(string str)
        {
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();            
            
            // Dado que los string son inmutables para modificarlo sin generar un nuevo objeto usamos la clase StringBuilder 
            StringBuilder sb = new StringBuilder();
            byte[] stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
            {
                // Se agrega la cadena formateada al StringBuilder
                sb.AppendFormat("{0:x2}", stream[i]);
            }                 
            return sb.ToString();
        }
    }
}
