﻿using System.Collections.Generic;
using Covid19Radar.Model;
using Covid19Radar.Renderers;
using Prism.Navigation;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class DescriptionPage4ViewModel : ViewModelBase
    {
        public DescriptionPage4ViewModel(INavigationService navigationService, IStatusBarPlatformSpecific statusBarPlatformSpecific) : base(navigationService, statusBarPlatformSpecific)
        {
            Title = Resources.AppResources.TitleHowItWorks;
        }

        public Command OnClickNext => new Command(async () =>
        {
            await NavigationService.NavigateAsync("ConsentByUserPage");
        });
    }
}