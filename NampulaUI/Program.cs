using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nampula.UI;
using NampulaDI;
using NampulaDI.Factory;
using NampulaDI.Repository;
using NampulaUI;
using System;

namespace NampulaUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string nameSpace = "Nampula";

            var app = Application.GetInstance();
            app.OnStartCreateMenu += app_OnStartCreatMenu;
            app.OnStartConnection += app_OnStartConnection;

            if (app.StartApplication(nameSpace, eAppType.SAPForms))
                System.Windows.Forms.Application.Run(app.MainForm());
        }

        private static void app_OnStartConnection(object sender, ApplicationEventArgs e)
        {
            new DBNampula().Start(Application.GetInstance().GetParam());
        }

        private static void app_OnStartCreatMenu(object sender, ApplicationEventArgs e)
        {
            const string tituloMenu = "Dados dos gatos";
            const string tituloForm = "Lista de gatos";

            var moduloMenu = Application.GetInstance().GetMenu(MenuID.cBoUIModulesMenu);
            var menuGroup = new MenuItem(moduloMenu, BoMenuType.mt_POPUP, tituloMenu);
            var menuNampulaForm = new MenuItem(menuGroup, BoMenuType.mt_STRING, tituloForm);
            menuNampulaForm.OnAfterClick += menuNampulaForm_OnAfterClick;

        }

        private static void menuNampulaForm_OnAfterClick(object sender, MenuEventArgs e)
        {
            var builder = CriaHostBuilder();
            var build = builder.Build();
            var servicesProvider = build.Services;

            var form = servicesProvider.GetRequiredService<Tabela>();
            form.Show();
        }

        static IHostBuilder CriaHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<Tabela>();
                    services.AddScoped<IRepositorio, Repositorio>();
                });
        }
    }
}