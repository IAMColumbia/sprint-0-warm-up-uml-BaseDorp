using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;

namespace Sprint_0_Warm_Up.NinjectModules
{
    public class EngineModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEngine>().To<JetEngine>().WhenInjectedExactlyInto<Airplane>();
            Bind<IEngine>().To<ReciprocatingEngine>().WhenInjectedExactlyInto<Helicopter>();
            Bind<IEngine>().To<RubberBandEngine>().WhenInjectedExactlyInto<ToyPlane>();
            Bind<IEngine>().To<UAVEngine>().WhenInjectedExactlyInto<Drone>();
        }
    }
}
