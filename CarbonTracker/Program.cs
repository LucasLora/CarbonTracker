using System;
using System.Windows.Forms;
using CarbonTracker.Models;
using CarbonTracker.Presenters;
using CarbonTracker.Views;
using CarbonTracker.Services;
using CarbonTracker._Repositories;
using System.Configuration;

namespace CarbonTracker
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Obtém a string de conexão do arquivo de configuração
            string stringConexao = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

            //Inicializa o serviço de autenticação
            IUsuariosRepository usuariosRepository = new UsuariosRepository(stringConexao);
            AutenticacaoService autenticacaoService = new AutenticacaoService(usuariosRepository);

            //Cria o form de login
            ILoginView loginForm = new LoginView();
            LoginPresenter loginPresenter = new LoginPresenter(loginForm, autenticacaoService);
            Application.Run((Form)loginForm);

            // Verifica se o login foi bem-sucedido antes de continuar
            if (loginForm.IsSuccessful)
            {
                if (loginPresenter.UsuarioLogado != null)
                {
                    IMainView view = new MainView();
                    new MainPresenter(loginPresenter.UsuarioLogado, view, stringConexao);
                    Application.Run((Form)view);
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
