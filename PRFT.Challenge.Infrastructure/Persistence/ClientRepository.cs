using PRFT.Challenge.Application.Common.Interfaces.Persistence;
using PRFT.Challenge.Domain.ClientAggregate;

namespace PRFT.Challenge.Infrastructure.Persistence
{
    public class ClientRepository : IClientRepository
    {
        private static readonly List<Client> _clients = new ();

        public void Add(Client client)
        {
            _clients.Add(client);
        }
    }
}
