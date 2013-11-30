using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace simlesService.Model
{
    [Route("/client", "POST")]
    [Route("/client/{Id}", "POST")]
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Address> Addresses { get; set; }

        public List<string> Telephones { get; set; }

        public List<string> Emails { get; set; }
    }

    public class ClientResponse
    {
        public int Id { get; set; }
        //the below catches exception data and sends it as part of the response
        public ResponseStatus ResponseStatus { get; set; }
    }
}