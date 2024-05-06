using CarbonTracker.Models;
using CarbonTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class UsuariosPresenter
    {

        #region Campos

        private IUsuariosView view;
        private IUsuariosRepository repository;
        private BindingSource usuariosBindingSource;
        private IEnumerable<UsuariosModel> usuariosList;

        #endregion

        #region Construtor

        public UsuariosPresenter(IUsuariosView view, IUsuariosRepository repository)
        {
            this.usuariosBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Vincular os EventHandler com os eventos da view
            this.view.SearchEvent += SearchUsuarios;
            this.view.AdicionarEvent += AdicionarUsuarios;
            this.view.AlterarEvent += CarregaUsuariosSelecionadoParaAlterar;
            this.view.ExcluirEvent += ExcluirUsuariosSelecionado;
            this.view.SalvarEvent += SalvarUsuarios;
            this.view.CancelarEvent += CancelarAcao;

            //Setar Usuarios binding source
            this.view.SetUsuariosListBindingSource(usuariosBindingSource);

            //Carregar a lista de Usuarios
            CarregaTodaListaUsuarios();

            //Mostrar view
            this.view.Show();
        }

        #endregion

        #region Métodos

        private void CarregaTodaListaUsuarios()
        {
            usuariosList = repository.RetornarTodos();
            usuariosBindingSource.DataSource = usuariosList;
        }

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
            view.UsuariosTipoUsuario = Usuarios.TipoUsuarios.ToString();
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
            model.TipoUsuarios = Convert.ToInt16(view.UsuariosTipoUsuario);
            model.Email = view.UsuariosEmail.ToString();
            model.Senha = view.UsuariosSenha.ToString();
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit) //Alteracao
                {
                    model.DataCriacao = Convert.ToDateTime(view.UsuariosDataCriacao);
                    repository.Alterar(model);
                    view.Message = "Usuário alterado com sucesso!";
                }
                else //Adicionar
                {
                    model.DataCriacao = DateTime.Now;
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

        private void LimparCamposDaView()
        {
            view.UsuariosId = "0";
            view.UsuariosNome = "";
            view.UsuariosSenha = "";
            view.UsuariosEmail = "";
            view.UsuariosTipoUsuario = "0";
            view.UsuariosDataCriacao = "";
        }

        #endregion

    }
}
