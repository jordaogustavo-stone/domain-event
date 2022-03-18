using MediatR;

namespace AplicacaoDeTeste
{
    internal class NotificacaoAcesso : INotification
    {
        public string Mensagem { get; private set; }

        public NotificacaoAcesso(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
