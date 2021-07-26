using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule
        : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GenreManager>().As<IGenreService>();
            builder.RegisterType<EfGenreDal>().As<IGenreDal>();
            builder.RegisterType<AlbumManager>().As<IAlbumService>();
            builder.RegisterType<EfAlbumDal>().As<IAlbumDal>();
            builder.RegisterType<ArtistManager>().As<IArtistService>();
            builder.RegisterType<EfArtistDal>().As<IArtistDal>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                });
        }

    }
}
