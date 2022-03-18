using MediatR;
using Microsoft.Extensions.Logging;

namespace AplicacaoDeTeste
{
    internal class NotificacaoAcessoHandler : INotificationHandler<NotificacaoAcesso>
    {
        private readonly ILogger<NotificacaoAcesso> _logger;

        public NotificacaoAcessoHandler(ILogger<NotificacaoAcesso> logger)
        {
            _logger = logger;
        }

        public async  Task Handle(NotificacaoAcesso notification, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                _logger.LogInformation(message: notification.Mensagem);
            }, cancellationToken);
        }
    }
}
