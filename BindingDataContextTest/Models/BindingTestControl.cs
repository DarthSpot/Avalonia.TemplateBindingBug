using Avalonia;
using Avalonia.Controls;
using BindingDataContextTest.ViewModels;

namespace BindingDataContextTest.Models
{
    public class BindingTestControl : ContentControl
    {
        public static readonly StyledProperty<string> StringStyledProperty =
            AvaloniaProperty.Register<BindingTestControl, string>(nameof(StringStyled));

        public static readonly DirectProperty<BindingTestControl, string> StringDirectProperty =
            AvaloniaProperty.RegisterDirect<BindingTestControl, string>(nameof(StringDirect),
                o => o.StringDirect,
                (o, v) => o.StringDirect = v);

        private string _direct;

        public string StringDirect
        {
            get => _direct;
            set => SetAndRaise(StringDirectProperty, ref _direct, value);
        }

        public string StringStyled
        {
            get => GetValue(StringStyledProperty);
            set => SetValue(StringStyledProperty, value);
        }
    }
    
    public class BindingTestControlWithDataContext : BindingTestControl
    {
        public BindingTestControlWithDataContext()
        {
            DataContext = new TestViewModel();
        }
    }

    public class TestViewModel : ViewModelBase
    {
    }
}