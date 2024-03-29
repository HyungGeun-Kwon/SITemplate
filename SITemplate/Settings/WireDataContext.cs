﻿using CvsService.Prism.Interfaces;
using Prism.Mvvm;
using SITemplate.ControlBar.ViewModels;
using SITemplate.ControlBar.Views;
using SITemplate.Inspection.ViewModels;
using SITemplate.Inspection.Views;
using SITemplate.Main.ViewModels;
using SITemplate.Main.Views;
using SITemplate.Setting.ViewModels;
using SITemplate.Setting.Views;
using SITemplate.Splash.ViewModels;
using SITemplate.Splash.Views;

namespace SITemplate.Settings
{
    public class WireDataContext : IViewViewModelWire
    {
        public void WireVVM()
        {
            // TODO : View - ViewModel 연결해주는 부분.
            ViewModelLocationProvider.Register<MainWindow, MainViewModel>();
            ViewModelLocationProvider.Register<SplashWindow, SplashViewModel>();
            ViewModelLocationProvider.Register<InspectionView, InspectionViewModel>();
            ViewModelLocationProvider.Register<SettingView, SettingViewModel>();
            ViewModelLocationProvider.Register<ControlBarView, ControlBarViewModel>();
        }
    }
}
