
using AplicacaoDeTeste;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;


CreateHostBuilder(args).Build()
                       .RunAsync();

var usuario = new Usuario("Gustavo Jordao");

await usuario.Logar().ConfigureAwait(false);


static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            {
                services.AddMediatR(typeof(Program).Assembly);
                ServiceLocator.SetLocatorProvider(services.BuildServiceProvider());
                DomainEvents.Mediator = () => ServiceLocator.Current.GetInstance<IMediator>();
            }
            );