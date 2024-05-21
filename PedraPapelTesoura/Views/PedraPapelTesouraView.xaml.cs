namespace PedraPapelTesoura.Views;
using PedraPapelTesoura.ViewModel;
using PedraPapelTesoura.Model;

public partial class PedraPapelTesouraView : ContentPage
{
    public PedraPapelTesouraView()
    {
        InitializeComponent();
        BindingContext = new PedraPapelTesouraViewModel();
    }
}