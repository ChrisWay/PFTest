using DLToolkit.PageFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PFTest
{
    public class App : Application
    {
        public App() {
            // The root page of your application
            var pageFactory = new XamarinFormsPageFactory();
            var navigationPage = pageFactory.Init<HelloViewModel, PFNavigationPage>();
            MainPage = navigationPage;
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
