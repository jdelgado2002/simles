using System.Collections.Generic;

using ServiceStack.ServiceHost;
namespace simlesService.Model {

    [Route("/client", "POST")]
    public class Client {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Address> Addresses { get; set; }

        public List<string> Telephones { get; set; }

        public List<string> Emails { get; set; }
    }

    public class ClientResponse {
        public int Id { get; set; }
    }
}