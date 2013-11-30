using System;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace simlesService.Model
{
    [Route("/appointment", "POST")]
    [Route("/appointment/{Id}", "POST")]
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public Client Client { get; set; }
    }

    public class AppointmentResponse
    {
        public int Id { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}