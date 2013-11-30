using ServiceStack.ServiceInterface;
using simlesService.Model;

namespace simlesService
{
    public class AppointmentService : Service
    {
        public object Post(Appointment appointment)
        {
            return new AppointmentResponse {Id = appointment.Id};
        }
    }
}