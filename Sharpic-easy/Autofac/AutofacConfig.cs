using Autofac;
using Sharpic_easy.Interfaces;
using Sharpic_easy.Repositories;
namespace Sharpic_easy.Autofac
{
    public class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Sharpic>();
            builder.RegisterType<FakeMessageRepo>().As<IMessageRepo>();
            builder.RegisterType<FakeReplyRepo>().As<IReplyRepo>();
            return builder.Build();
        }
    }
}
