using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace TrackR.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
    }
}
