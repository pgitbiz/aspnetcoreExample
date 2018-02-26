namespace PGIT.B2Coin.Web2.API
{
    using Autofac;

    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            //builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>()
            //    .InstancePerRequest();
        }
    }
}
