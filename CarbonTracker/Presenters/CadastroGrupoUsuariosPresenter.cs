using CarbonTracker.Models;
using CarbonTracker.Presenters.Common;
using CarbonTracker.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class CadastroGrupoUsuariosPresenter
    {

        #region Campos

        private ICadastroGrupoUsuariosView view;
        private IGrupoUsuariosRepository repository;
        private BindingSource grupoUsuariosBindingSource = new BindingSource();
        private IEnumerable<GrupoUsuariosModel> grupoUsuariosList;

        #endregion

        #region Construtor

        public CadastroGrupoUsuariosPresenter(ICadastroGrupoUsuariosView view, IGrupoUsuariosRepository repository)
        {
            this.view = view;
            this.repository = repository;

            VincularEventos();
            SetBindings();
            CarregaTodaListaGrupoUsuarios();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.SearchEvent += SearchGrupoUsuarios;
            this.view.AdicionarEvent += AdicionarGrupoUsuarios;
            this.view.AlterarEvent += CarregaGrupoUsuariosSelecionadoParaAlterar;
            this.view.ExcluirEvent += ExcluirGrupoUsuariosSelecionado;
            this.view.SalvarEvent += SalvarGrupoUsuarios;
            this.view.CancelarEvent += CancelarAcao;
        }

        private void SetBindings()
        {
            this.view.SetGrupoUsuariosListBindingSource(grupoUsuariosBindingSource);
        }

        private void CarregaTodaListaGrupoUsuarios()
        {
            grupoUsuariosList = repository.RetornarTodos();
            grupoUsuariosBindingSource.DataSource = grupoUsuariosList;
        }

        private void LimparCamposDaView()
        {
            view.GrupoUsuariosId = "0";
            view.GrupoUsuariosNome = "";
            view.GrupoUsuariosDescricao = "";
        }

        #endregion

        #region Eventos

        private void SearchGrupoUsuarios(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            { 
                grupoUsuariosList = repository.RetornarPorId(this.view.SearchValue);
            }
            else
            {
                grupoUsuariosList = repository.RetornarTodos();
            }

            grupoUsuariosBindingSource.DataSource = grupoUsuariosList;
        }

        private void AdicionarGrupoUsuarios(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CarregaGrupoUsuariosSelecionadoParaAlterar(object sender, EventArgs e)
        {
            var grupoUsuarios = (GrupoUsuariosModel)grupoUsuariosBindingSource.Current;
            view.GrupoUsuariosId = grupoUsuarios.Id.ToString();
            view.GrupoUsuariosNome = grupoUsuarios.Nome;
            view.GrupoUsuariosDescricao = grupoUsuarios.Descricao;
            view.IsEdit = true;
        }

        private void ExcluirGrupoUsuariosSelecionado(object sender, EventArgs e)
        {
            try
            {
                var grupoUsuarios = (GrupoUsuariosModel)grupoUsuariosBindingSource.Current;
                repository.Excluir(grupoUsuarios.Id);
                view.IsSuccessful = true;
                view.Message = "Grupo de Usuários excluído com sucesso!";
                CarregaTodaListaGrupoUsuarios();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "Um erro ocorreu, não foi possível excluir o Grupo de Usuários!";
            }
        }

        private void SalvarGrupoUsuarios(object sender, EventArgs e)
        {
            var model = new GrupoUsuariosModel();
            model.Id = Convert.ToInt64(view.GrupoUsuariosId);
            model.Nome = view.GrupoUsuariosNome.ToString();
            model.Descricao = view.GrupoUsuariosDescricao.ToString();
            try
            {
                new ModelDataValidation().Validate(model);
                if (view.IsEdit) //Alterar
                {
                    repository.Alterar(model);
                    view.Message = "Grupo de Usuários alterado com sucesso!";
                }
                else //Adicionar
                {
                    repository.Adicionar(model);
                    view.Message = "Grupo de Usuários adicionado com sucesso!";
                }
                view.IsSuccessful = true;
                CarregaTodaListaGrupoUsuarios();
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
