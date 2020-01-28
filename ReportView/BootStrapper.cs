using Caliburn.Micro;
using ReportView.Models;
using ReportView.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ReportView
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            _container.Instance(_container);

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<ShellViewModel>()
                .Singleton<PersonViewModel>()
                .Singleton<ReportPageViewModel>()
                .Singleton<ScrollViewModel>()
                .Singleton<PersonModel>()
                .PerRequest<UserControlViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}