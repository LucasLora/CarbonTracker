using System;
using System.Windows.Forms;

namespace CarbonTracker.Views.Interfaces
{
    public interface IComparacoesView
    {

        #region Propriedades

        DateTime DiaInicial { get; set; }
        DateTime DiaFinal { get; set; }
        bool CompararGrupos { get; set; }
        string Pontuacao { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler CompararEvent;
        event EventHandler MensalEvent;
        event EventHandler TrimestralEvent;
        event EventHandler SemestralEvent;
        event EventHandler AnualEvent;

        #endregion

        #region Métodos

        void BloquearBotoes(bool bloquear);
        void SetPosicaoGruposUsuariosListBindingSource(BindingSource posicaoGruposUsuarios);
        void Show();

        #endregion

    }
}
