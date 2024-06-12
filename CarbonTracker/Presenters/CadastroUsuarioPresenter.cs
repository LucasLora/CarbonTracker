using CarbonTracker.Models;
using CarbonTracker.Presenters.Common;
using CarbonTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;
using static CarbonTracker.Presenters.Common.ComboBoxHelper;

namespace CarbonTracker.Presenters
{
    public class CadastroUsuarioPresenter
    {

        #region Campos

        private UsuarioModel usuarioLogado;
        private ICadastroUsuarioView view;
        private IUsuariosRepository repository;
        private BindingSource usuariosBindingSource = new BindingSource();
        private IEnumerable<UsuarioModel> usuariosList;
        private BindingSource tipoUsuarioBindingSource = new BindingSource();

        #endregion

        #region Construtor

        public CadastroUsuarioPresenter(UsuarioModel usuarioLogado, ICadastroUsuarioView view, IUsuariosRepository repository)
        {
            this.usuarioLogado = usuarioLogado;
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
            var usuariosList = repository.RetornarTodos();

            if (usuarioLogado.TipoUsuario == TipoUsuario.Administrador)
            {
                usuariosList = usuariosList.Where(x => x.TipoUsuario != TipoUsuario.Administrador).ToList();
            }
            else if (usuarioLogado.TipoUsuario == TipoUsuario.Supervisor)
            {
                usuariosList = usuariosList.Where(x => x.TipoUsuario != TipoUsuario.Administrador &&
                                                       x.TipoUsuario != TipoUsuario.Supervisor).ToList();
            }

            usuariosBindingSource.DataSource = usuariosList;
        }
    
        private void CarregaComboBindings()
        {
            var tipoUsuario = GetComboBoxItemListFromEnum<TipoUsuario>();

            if (usuarioLogado.TipoUsuario == TipoUsuario.Administrador)
            {
                tipoUsuario = tipoUsuario.Where(x => !string.Equals(x.Text, "Administrador", StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
            else if (usuarioLogado.TipoUsuario == TipoUsuario.Supervisor)
            {
                tipoUsuario = tipoUsuario.Where(x => !string.Equals(x.Text, "Administrador", StringComparison.CurrentCultureIgnoreCase) &&
                                                     !string.Equals(x.Text, "Supervisor", StringComparison.CurrentCultureIgnoreCase)).ToList();
            }

            tipoUsuarioBindingSource.DataSource = tipoUsuario;
        }

        private void LimparCamposDaView()
        {
            view.UsuarioId = "0";
            view.UsuarioNome = "";
            view.UsuarioEmail = "";
            view.UsuarioSenha = "";
            view.UsuarioTipoUsuario = TipoUsuario.Usuario;
            view.UsuarioDataCriacao = "";
        }

        #endregion

        #region Eventos

        private void SearchUsuarios(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            { 
                usuariosList = repository.RetornarPorId(this.view.SearchValue); 
            }
            else
            {
                usuariosList = repository.RetornarTodos(); 
            }

            usuariosBindingSource.DataSource = usuariosList;
        }

        private void AdicionarUsuarios(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CarregaUsuariosSelecionadoParaAlterar(object sender, EventArgs e)
        {
            var Usuarios = (UsuarioModel)usuariosBindingSource.Current;
            view.UsuarioId = Usuarios.Id.ToString();
            view.UsuarioNome = Usuarios.Nome;
            view.UsuarioTipoUsuario = Usuarios.TipoUsuario;
            view.UsuarioEmail = Usuarios.Email.ToString();
            view.UsuarioSenha = Usuarios.Senha.ToString();
            view.UsuarioDataCriacao = Usuarios.DataCriacao.ToString();
            view.IsEdit = true;
        }

        private void ExcluirUsuariosSelecionado(object sender, EventArgs e)
        {
            try
            {
                var Usuarios = (UsuarioModel)usuariosBindingSource.Current;
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
            var model = new UsuarioModel();
            model.Id = Convert.ToInt64(view.UsuarioId);
            model.Nome = view.UsuarioNome.ToString();
            model.TipoUsuario = view.UsuarioTipoUsuario;
            model.Email = view.UsuarioEmail.ToString();
            model.Senha = view.UsuarioSenha.ToString();
            model.DataCriacao = DateTime.Now;
            try
            {
                new ModelDataValidation().Validate(model);

                if (repository.RetornarTodos().Any(x => x.Email == model.Email && x.Id != model.Id))
                {
                    throw new Exception("Já existe um usuário com este e-mail!");
                }
                
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
