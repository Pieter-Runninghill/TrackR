using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(SignUpViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}