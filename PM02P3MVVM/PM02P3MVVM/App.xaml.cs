using PM02P3MVVM.Services;
using PM02P3MVVM.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02P3MVVM
{
    public partial class App : Application
    {
        static ProductService _productService;
        public static ProductService ProductService
        {
            get
            {
                if(_productService == null)
                {
                    _productService = new ProductService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Product.db3"));
                }

                return _productService;
            }
        }


        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
