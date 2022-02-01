using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace BindingDataContextTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _stringTest;

        public string StringTest
        {
            get => _stringTest;
            set => this.RaiseAndSetIfChanged(ref _stringTest, value);
        }

        public MainWindowViewModel()
        {
            StringTest = "Hello World";
        }
    }
}