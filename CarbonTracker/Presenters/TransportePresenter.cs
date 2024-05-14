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
    public class TransportePresenter
    {

        #region Campos

        private ITransporteView view;
        private ITransporteRepository repository;
        private BindingSource transporteBindingSource;
        private IEnumerable<TransporteModel> transporteList;
        private BindingSource tipoVeiculoBindingSource;
        private BindingSource tipoCombustivelBindingSource;

        #endregion

        #region Construtor

        public TransportePresenter(ITransporteView view, ITransporteRepository repository)
        {
            this.transporteBindingSource = new BindingSource();
            this.tipoVeiculoBindingSource = new BindingSource();
            this.tipoCombustivelBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            //Vincular os eventos da view com os métodos
            this.view.SearchEvent += SearchTransporte;
            this.view.AdicionarEvent += AdicionarTransporte;
            this.view.AlterarEvent += CarregaTransporteSelecionadoParaAlterar;
            this.view.ExcluirEvent += ExcluirTransporteSelecionado;
            this.view.SalvarEvent += SalvarTransporte;
            this.view.CancelarEvent += CancelarAcao;

            //Vincular os bindings sources com a view
            this.view.SetTransporteListBindingSource(transporteBindingSource);
            this.view.SetComboBoxVeiculoBindingSource(tipoVeiculoBindingSource);
            this.view.SetComboBoxCombustivelBindingSource(tipoCombustivelBindingSource);

            //Carregar dados
            CarregaTodaListaTransporte();
            CarregaVeiculos();
            CarregaCombustiveis();

            //Mostrar view
            this.view.Show();
        }

        #endregion

        #region Métodos

        private void CarregaTodaListaTransporte()
        {
            transporteList = repository.RetornarTodos();
            transporteBindingSource.DataSource = transporteList;
        }

        private void CarregaVeiculos()
        {
            tipoVeiculoBindingSource.DataSource = GetEnumInComboBoxItemList<TipoVeiculo>();
        }
        
        private void CarregaCombustiveis()
        {
            tipoCombustivelBindingSource.DataSource = GetEnumInComboBoxItemList<TipoCombustivel>();
        }

        private void SearchTransporte(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            { transporteList = repository.RetornarPorId(this.view.SearchValue); }
            else
            { transporteList = repository.RetornarTodos(); }

            transporteBindingSource.DataSource = transporteList;
        }

        private void AdicionarTransporte(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CarregaTransporteSelecionadoParaAlterar(object sender, EventArgs e)
        {
            var transporte = (TransporteModel)transporteBindingSource.Current;
            view.TransporteId = transporte.Id.ToString();
            view.TransporteNome = transporte.Nome;
            view.TransporteTipoCombustivel = transporte.TipoCombustivel;
            view.TransporteTipoVeiculo = transporte.TipoVeiculo;
            view.TransporteKmPorLitroCombustivel = transporte.KmPorLitroCombustivel.ToString();
            view.IsEdit = true;
        }

        private void ExcluirTransporteSelecionado(object sender, EventArgs e)
        {
            try
            {
                var transporte = (TransporteModel)transporteBindingSource.Current;
                repository.Excluir(transporte.Id);
                view.IsSuccessful = true;
                view.Message = "Tranporte excluído com sucesso!";
                CarregaTodaListaTransporte();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "Um erro ocorreu, não foi possível excluir o transporte!";
            }
        }

        private void SalvarTransporte(object sender, EventArgs e)
        {
            var model = new TransporteModel();
            model.Id = Convert.ToInt64(view.TransporteId);
            model.Nome = view.TransporteNome.ToString();
            model.TipoVeiculo = view.TransporteTipoVeiculo;
            model.TipoCombustivel = view.TransporteTipoCombustivel;
            model.KmPorLitroCombustivel = double.TryParse(view.TransporteKmPorLitroCombustivel, out double kmPorLitroCombustivel) ? kmPorLitroCombustivel : 0;
            try
            {
                new ModelDataValidation().Validate(model);
                if (view.IsEdit) //Alterar
                {
                    repository.Alterar(model);
                    view.Message = "Transporte alterado com sucesso!";
                }
                else //Adicionar
                {
                    repository.Adicionar(model);
                    view.Message = "Transporte adicionado com sucesso!";
                }
                view.IsSuccessful = true;
                CarregaTodaListaTransporte();
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
            view.TransporteId = "0";
            view.TransporteNome = "";
            view.TransporteTipoCombustivel = TipoCombustivel.NaoAplica;
            view.TransporteTipoVeiculo = TipoVeiculo.Moto;
            view.TransporteKmPorLitroCombustivel = "0";
        }

        #endregion

    }
}
