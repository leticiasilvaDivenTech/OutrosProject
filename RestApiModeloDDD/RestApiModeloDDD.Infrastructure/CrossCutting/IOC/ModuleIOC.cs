using Autofac;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
   public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder build)
        {
            ConfigurationIOC.Load(build);
        }
    }
}
