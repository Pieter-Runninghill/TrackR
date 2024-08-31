using TrackR.ViewModel;

namespace TrackR.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(LoginViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;


            #if ANDROID
            if (Platform.CurrentActivity != null)
            {
                ((LoginViewModel)BindingContext).SetActivity(Platform.CurrentActivity);
            }
            #endif
        }
    }
}