using MediatR;

namespace AplicacaoDeTeste
{
    internal class Usuario : DomainEvents
    {
        public string Nome { get; set; }

        public Usuario(string nome)
        {
            Nome = nome;
        }

        public async Task Logar()
        {
            await Raise(new NotificacaoAcesso($"Usuario do nome:{Nome}, Acessou a aplicação!")).ConfigureAwait(false);
        }
    }
}
