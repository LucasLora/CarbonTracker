using CarbonTracker.Models;
using CarbonTracker.Presenters.Common;
using CarbonTracker.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;
using static CarbonTracker.Presenters.Common.ComboBoxHelper;

namespace CarbonTracker.Presenters
{
    public class UsuariosPresenter
    {

        #region Campos

        private IUsuariosView view;
        private IUsuariosRepository repository;
        private BindingSource usuariosBindingSource = new BindingSource();
        private IEnumerable<UsuariosModel> usuariosList;
        private BindingSource tipoUsuarioBindingSource = new BindingSource();

        #endregion

        #region Construtor

        public UsuariosPresenter(IUsuariosView view, IUsuariosRepository repository)
        {
            this.view = view;
            this.repository = repository;

            VincularEventos();
            SetBindings();
            CarregaTodaListaUsuarios();
            CarregaComboBindings();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.SearchEvent += SearchUsuarios;
            this.view.AdicionarEvent += AdicionarUsuarios;
            this.view.AlterarEvent += CarregaUsuariosSelecionadoParaAlterar;
            this.view.ExcluirEvent += ExcluirUsuariosSelecionado;
            this.view.SalvarEvent += SalvarUsuarios;
            this.view.CancelarEvent += CancelarAcao;
        }

        private void SetBindings()
        {
            this.view.SetUsuariosListBindingSource(usuariosBindingSource);
            this.view.SetComboBoxTipoUsuarioBindingSource(tipoUsuarioBindingSource);
        }

        private void CarregaTodaListaUsuarios()
        {
            usuariosList = repository.RetornarTodos();
            usuariosBindingSource.DataSource = usuariosList;
        }

        private void CarregaComboBindings()
        {
            tipoUsuarioBindingSource.DataSource = GetComboBoxItemListFromEnum<TipoUsuario>();
        }

        private void LimparCamposDaView()
        {
            view.UsuariosId = "0";
            view.UsuariosNome = "";
            view.UsuariosEmail = "";
            view.UsuariosSenha = "";
            view.UsuariosTipoUsuario = TipoUsuario.Usuario;
            view.UsuariosDataCriacao = "";
        }

        #endregion

        #region Eventos

        private void SearchUsuarios(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            { usuariosList = repository.RetornarPorId(this.view.SearchValue); }
            else
            { usuariosList = repository.RetornarTodos(); }

            usuariosBindingSource.DataSource = usuariosList;
        }

        private void AdicionarUsuarios(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CarregaUsuariosSelecionadoParaAlterar(object sender, EventArgs e)
        {
            var Usuarios = (UsuariosModel)usuariosBindingSource.Current;
            view.UsuariosId = Usuarios.Id.ToString();
            view.UsuariosNome = Usuarios.Nome;
            view.UsuariosTipoUsuario = Usuarios.TipoUsuario;
            view.UsuariosEmail = Usuarios.Email.ToString();
            view.UsuariosSenha = Usuarios.Senha.ToString();
            view.UsuariosDataCriacao = Usuarios.DataCriacao.ToString();
            view.IsEdit = true;
        }

        private void ExcluirUsuariosSelecionado(object sender, EventArgs e)
        {
            try
            {
                var Usuarios = (UsuariosModel)usuariosBindingSource.Current;
                repository.Excluir(Usuarios.Id);
                view.IsSuccessful = true;
                view.Message = "Usuário excluído com sucesso!";
                CarregaTodaListaUsuarios();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "Um erro ocorreu, não foi possível excluir o Usuário!";
            }
        }

        private void SalvarUsuarios(object sender, EventArgs e)
        {
            var model = new UsuariosModel();
            model.Id = Convert.ToInt64(view.UsuariosId);
            model.Nome = view.UsuariosNome.ToString();
            model.TipoUsuario = view.UsuariosTipoUsuario;
            model.Email = view.UsuariosEmail.ToString();
            model.Senha = view.UsuariosSenha.ToString();
            model.DataCriacao = DateTime.Now;
            try
            {
                new ModelDataValidation().Validate(model);
                if (view.IsEdit) //Alteracao
                {
                    repository.Alterar(model);
                    view.Message = "Usuário alterado com sucesso!";
                }
                else //Adicionar
                {
                    repository.Adicionar(model);
                    view.Message = "Usuário adicionado com sucesso!";
                }
                view.IsSuccessful = true;
                CarregaTodaListaUsuarios();
                LimparCamposDaView();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CancelarAcao(object sender, EventArgs e)
        {
            LimparCamposDaView();
        }

        #endregion

    }
}
