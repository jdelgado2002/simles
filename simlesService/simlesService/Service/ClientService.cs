using ServiceStack.ServiceInterface;
using simlesService.Model;
namespace simlesService {

    public class ClientService : Service {
        public object Post(Client client) {
            //todo: update-create client entry using repository, return id of created client
            return new ClientResponse { Id = 111 };
        }
    }
}