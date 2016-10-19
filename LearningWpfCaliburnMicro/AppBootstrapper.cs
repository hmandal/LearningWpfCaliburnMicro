namespace LearningWpfCaliburnMicro
{
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    using MyApp;
    using Color;
    using Ninject;

    public class AppBootstrapper : BootstrapperBase
    {
        private IKernel _kernel;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _kernel = new StandardKernel();

            _kernel.Bind<IWindowManager>().To<WindowManager>().InSingletonScope();
            _kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            _kernel.Bind<MyAppViewModel>().To<MyAppViewModel>().InSingletonScope();
            _kernel.Bind<ColorViewModel>().To<ColorViewModel>().InSingletonScope();
        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = _kernel.Get(service);
            if (instance != null)
                return instance;

            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _kernel.GetAll(service);
        }

        protected override void BuildUp(object instance)
        {
            _kernel.Inject(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<MyAppViewModel>();
        }
    }
}