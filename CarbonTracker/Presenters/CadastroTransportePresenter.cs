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
    public class CadastroTransportePresenter
    {

        #region Campos

        private ICadastroTransporteView view;
        private ITransporteRepository repository;
        private BindingSource transporteBindingSource = new BindingSource();
        private IEnumerable<TransporteModel> transporteList;
        private BindingSource tipoVeiculoBindingSource = new BindingSource();
        private BindingSource tipoCombustivelBindingSource = new BindingSource();

        #endregion

        #region Construtor

        public CadastroTransportePresenter(ICadastroTransporteView view, ITransporteRepository repository)
        {
            this.view = view;
            this.repository = repository;

            VincularEventos();
            SetBindings();
            CarregaTodaListaTransporte();
            CarregaComboBindings();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.SearchEvent += SearchTransporte;
            this.view.AdicionarEvent += AdicionarTransporte;
            this.view.AlterarEvent += CarregaTransporteSelecionadoParaAlterar;
            this.view.ExcluirEvent += ExcluirTransporteSelecionado;
            this.view.SalvarEvent += SalvarTransporte;
            this.view.CancelarEvent += CancelarAcao;
        }

        private void SetBindings()
        {
            this.view.SetTransporteListBindingSource(transporteBindingSource);
            this.view.SetComboBoxTipoVeiculoBindingSource(tipoVeiculoBindingSource);
            this.view.SetComboBoxTipoCombustivelBindingSource(tipoCombustivelBindingSource);
        }

        private void CarregaTodaListaTransporte()
        {
            transporteList = repository.RetornarTodos();
            transporteBindingSource.DataSource = transporteList;
        }

        private void CarregaComboBindings()
        {
            tipoVeiculoBindingSource.DataSource = GetComboBoxItemListFromEnum<TipoVeiculo>();
            tipoCombustivelBindingSource.DataSource = GetComboBoxItemListFromEnum<TipoCombustivel>();
        }

        private void LimparCamposDaView()
        {
            view.TransporteId = "0";
            view.TransporteNome = "";
            //view.TransporteTipoCombustivel = TipoCombustivel.NaoAplica;
            //view.TransporteTipoVeiculo = TipoVeiculo.Moto;
            view.TransporteKmPorLitroCombustivel = "0";
        }

        #endregion

        #region Eventos

        private void SearchTransporte(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            { 
                transporteList = repository.RetornarPorId(this.view.SearchValue); 
            }
            else
            { 
                transporteList = repository.RetornarTodos(); 
            }

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

        #endregion

    }
}
