using Unity;
namespace UnitToolTest.AppConfig
{
    public static class UnityConfig
    {
        public static void RegisterComponents( )
        {

            var Container=new UnityContainer();

            // methana thamai DI okkoma tika hadanne. 
            DependancyResolver.setResolver(new UnityDependancyResolver(Container));
        }

    }   
}