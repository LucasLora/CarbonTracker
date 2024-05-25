﻿using CarbonTracker.Models;
using System.Linq;

namespace CarbonTracker.Services
{
    public class AutenticacaoService
    {

        #region Campos

        private readonly IUsuariosRepository _usuariosRepository;
        private UsuariosModel usuarioAutenticado = null;

        #endregion

        public UsuariosModel UsuarioAutenticado { get { return usuarioAutenticado; } }

        #region Construtor

        public AutenticacaoService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        #endregion

        #region Métodos

        public bool Autenticar(string username, string password)
        {
            var user = _usuariosRepository.RetornarTodos().FirstOrDefault(x => x.Email == username);
            if (user != null && user.Senha == password)
            {
                usuarioAutenticado = user;
                return true;
            }
            return false;
        }

        #endregion

    }
}
