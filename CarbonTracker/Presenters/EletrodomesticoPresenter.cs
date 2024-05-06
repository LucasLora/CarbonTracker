using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarbonTracker.Models;
using CarbonTracker.Views;

namespace CarbonTracker.Presenters
{
    public class EletrodomesticoPresenter
    {

        #region Campos

        private IEletrodomesticoView view;
        private IEletrodomesticoRepository repository;
        private BindingSource eletrodomesticoBindingSource;
        private IEnumerable<EletrodomesticoModel> eletrodomesticoList;

        #endregion

        #region Construtor

        public EletrodomesticoPresenter(IEletrodomesticoView view, IEletrodomesticoRepository repository)
        {
            this.eletrodomesticoBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Vincular os eventos da view com os métodos
            this.view.SearchEvent += SearchEletrodomestico;
            this.view.AdicionarEvent += AdicionarEletrodomestico;
            this.view.AlterarEvent += CarregaEletrodomesticoSelecionadoParaAlterar;
            this.view.ExcluirEvent += ExcluirEletrodomesticoSelecionado;
            this.view.SalvarEvent += SalvarEletrodomestico;
            this.view.CancelarEvent += CancelarAcao;

            //Setar Eletrodomestico binding source
            this.view.SetEletrodomesticoListBindingSource(eletrodomesticoBindingSource);

            CarregaTodaListaEletrodomestico();

            //Mostrar view
            this.view.Show();
        }

        #endregion

        #region Métodos

        private void CarregaTodaListaEletrodomestico()
        {
            eletrodomesticoList = repository.RetornarTodos();
            eletrodomesticoBindingSource.DataSource = eletrodomesticoList;
        }

        private void SearchEletrodomestico(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            { eletrodomesticoList = repository.RetornarPorId(this.view.SearchValue); }
            else
            { eletrodomesticoList = repository.RetornarTodos(); }

            eletrodomesticoBindingSource.DataSource = eletrodomesticoList;
        }

        private void AdicionarEletrodomestico(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CarregaEletrodomesticoSelecionadoParaAlterar(object sender, EventArgs e)
        {
            var eletrodomestico = (EletrodomesticoModel)eletrodomesticoBindingSource.Current;
            view.EletrodomesticoId = eletrodomestico.Id.ToString();
            view.EletrodomesticoNome = eletrodomestico.Nome;
            view.EletrodomesticoLitroPorHoraAgua = eletrodomestico.LitroPorHoraAgua.ToString();
            view.EletrodomesticoKWPorHoraEletricidade = eletrodomestico.KWPorHoraEletricidade.ToString();
            view.IsEdit = true;
        }

        private void ExcluirEletrodomesticoSelecionado(object sender, EventArgs e)
        {
            try
            {
                var eletrodomestico = (EletrodomesticoModel)eletrodomesticoBindingSource.Current;
                repository.Excluir(eletrodomestico.Id);
                view.IsSuccessful = true;
                view.Message = "Eletrodoméstico excluído com sucesso!";
                CarregaTodaListaEletrodomestico();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "Um erro ocorreu, não foi possível excluir o eletrodoméstico!";
            }
        }

        private void SalvarEletrodomestico(object sender, EventArgs e)
        {
            var model = new EletrodomesticoModel();
            model.Id = Convert.ToInt64(view.EletrodomesticoId);
            model.Nome = view.EletrodomesticoNome.ToString();
            model.LitroPorHoraAgua = Convert.ToDouble(view.EletrodomesticoLitroPorHoraAgua);
            model.KWPorHoraEletricidade = Convert.ToDouble(view.EletrodomesticoKWPorHoraEletricidade);
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit) //Alterar
                {
                    repository.Alterar(model);
                    view.Message = "Eletrodoméstico alterado com sucesso!";
                }
                else //Adicionar
                {
                    repository.Adicionar(model);
                    view.Message = "Eletrodoméstico adicionado com sucesso!";
                }
                view.IsSuccessful = true;
                CarregaTodaListaEletrodomestico();
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
            view.EletrodomesticoId = "0";
            view.EletrodomesticoNome = "";
            view.EletrodomesticoLitroPorHoraAgua = "0";
            view.EletrodomesticoKWPorHoraEletricidade = "0";
        }

        #endregion

    }
}
