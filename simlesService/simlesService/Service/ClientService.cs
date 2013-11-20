using ServiceStack.ServiceInterface;
using simlesService.Model;
namespace simlesService {

    public class ClientService : Service {
        public object Post(Client client) {
            return new ClientResponse { Id = 111 };
        }
    }
}