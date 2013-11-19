namespace simlesService {
    using System;
    using System.Web;

    using Funq;

    using ServiceStack.WebHost.Endpoints;

    public class Global : HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            new SimlesAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e) {
        }

        protected void Application_BeginRequest(object sender, EventArgs e) {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {
        }

        protected void Application_Error(object sender, EventArgs e) {
        }

        protected void Session_End(object sender, EventArgs e) {
        }

        protected void Application_End(object sender, EventArgs e) {
        }

        public class SimlesAppHost : AppHostBase {
            public SimlesAppHost(): base("simles client", typeof(ClientService).Assembly) {
            }

            public override void Configure(Container container) {
            }
        }
    }
}