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

            builder.RegisterType<Sharpic>().SingleInstance();
            builder.RegisterType<FileMessageRepo>().As<IMessageRepo>().SingleInstance();
            builder.RegisterType<FileReplyRepo>().As<IReplyRepo>().SingleInstance();
            return builder.Build();
        }
    }
}
