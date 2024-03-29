﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace DotNetMauiApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            Items.Add(Text);
            Text = string.Empty;
        }
    }
}
