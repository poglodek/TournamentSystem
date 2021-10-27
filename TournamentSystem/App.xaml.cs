using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TournamentSystem.Database;
using TournamentSystem.View;

namespace TournamentSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            serviceProvider.GetService<TournamentSystemDbContext>().Database.Migrate();


            Window window = serviceProvider.GetService<MainWindow>();
            window.DataContext = serviceProvider.GetService<MainWindowViewModel>();
            window.Show();

            

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddDbContext<TournamentSystemDbContext>(options =>
                options.UseSqlServer("Server=.;Database=TournamentSystem;Trusted_Connection=True;")); ;


            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();

            return services.BuildServiceProvider();
        }

    }
}
