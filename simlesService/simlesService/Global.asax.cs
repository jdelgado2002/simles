namespace simlesService {
    using System;
    using System.Web;

    using Funq;

    using ServiceStack.CacheAccess;
    using ServiceStack.CacheAccess.Providers;
    using ServiceStack.ServiceInterface;
    using ServiceStack.ServiceInterface.Auth;
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

            public override void Configure(Funq.Container container) {
                Plugins.Add(new AuthFeature(() => new AuthUserSession(), new IAuthProvider[] {new BasicAuthProvider(), }));
                container.Register<ICacheClient>(new MemoryCacheClient());
                var userRepository = new InMemoryAuthRepository();
                container.Register<IUserAuthRepository>(userRepository);

                //adding test user
                string hash;
                string salt;

                new SaltedHash().GetHashAndSaltString("password", out hash, out salt);
                userRepository.CreateUserAuth(
                    new UserAuth() { Id = 1, DisplayName = "joselito", Email = "yiyo@hotmail.com", PasswordHash = hash, Salt = salt}, "password");
            }
        }
    }
}